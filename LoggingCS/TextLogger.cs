using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.Extensions.Options;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Logging.LoggingConfiguration;

public class TextLogger : AbstractLogger, ITextLogger
{
    private readonly LoggerConfiguration _loggerConfiguration;

    // base is from the abstract logger, which does nothing like saying AbstractLogger()
    public TextLogger(IOptions<LoggerConfiguration> loggingConfiguration) : base()
    {
        // Depdendency injectingggg
        _loggerConfiguration = loggingConfiguration.Value ?? throw new ArgumentException(nameof(loggingConfiguration));

        if (_loggerConfiguration.loggerType != LoggerType.Text)
        {
            throw new InvalidOperationException($"{nameof(TextLogger)} doesn't match LoggerType of {_loggerConfiguration.loggerType}");
        }

        string logDirectory = Path.Combine(_loggerConfiguration.textLoggerConfiguration.Directory, $"{DateTime.Now:yyyy-MM-dd}");

        Directory.CreateDirectory( logDirectory );

        string uniqueLogName = $"{_loggerConfiguration.textLoggerConfiguration.Filename}{DateTime.Now:HH_mm_ss}";

        // string baseLogName = Path.Combine( uniqueLogName, _loggerConfiguration.textLoggerConfiguration.FileExtension);
        string baseLogName = uniqueLogName + _loggerConfiguration.textLoggerConfiguration.FileExtension;

        string filepath = Path.Combine(logDirectory, baseLogName);

        // Token soruce has the token objec tinside it 
        _ = Task.Run(() => LogAsync(filepath, logQueue, tokenSource.Token));
    }

    // cancellation token so that it finishes gracefully 
    // we get it tof inish gracefully by finishign gracefully 
    private static async void LogAsync(string filepath, BufferBlock<LogInformation> q, CancellationToken token)
    {
        // <using> will let us dispose of soemthing 

        // filestream 
        using var fs = new FileStream(filepath, FileMode.CreateNew, FileAccess.Write, FileShare.Read);

        // stream writer to file stream
        using var sr = new StreamWriter(fs) {
            AutoFlush = true,
        };

        // this is a long running trask, so we use a while loop
        try
        {
            while (true)
            {
                var logItem = await q.ReceiveAsync(token).ConfigureAwait(false);
                string formattedMessage = FormatLogItem(logItem);
                await sr.WriteAsync(formattedMessage).ConfigureAwait(false);
                await Console.Out.WriteLineAsync(formattedMessage);
            }
        }
        catch (OperationCanceledException)
        {

        }

    }

    private static string FormatLogItem(LogInformation logItem)
    {
        // -30 adds padding
        // 000 is decimal places
        string name = logItem.threadName ?? "No name";
        return $"[{logItem.now:yyyy-MM-dd HH-mm-ss.fffffff}] [{name, -30}:{logItem.threadId:000}]"
           + $"[{logItem.logLevel}] {logItem.message}\n";
    }

    // Now the juicy part, how do we log? 
    protected override void Log(LogLevel logLevel, string module, string message)
    {
       // throw new NotImplementedException();

        // Synchronous post into the buffer block
        // We will pop this off a quee and format to a string and then put into a file 
        // When ti posts, we ensure ther eis not issue, cuz the Run function is async and running in the background
        logQueue.Post(new LogInformation(logLevel, module, message, DateTime.Now, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name));
        //Console.WriteLine("Adding");
    }


    // think of this as a destructor
    ~TextLogger()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        lock (_lock)
        {
            if (disposed)
            {
                return;
            }
        }

        disposed = true; 

        if (disposing)
        {
            // Get rid of managed resources
            tokenSource.Cancel();
            tokenSource.Dispose();
        }
        // get rid of unamanged resources
    }


    // BufferBlock is a thread safe queue
    // it has an asynchrnous api to work with our tasks 
    private readonly BufferBlock<LogInformation> logQueue = new BufferBlock<LogInformation>();
    private readonly CancellationTokenSource tokenSource = new CancellationTokenSource();

    private readonly object _lock = new object();

    private bool disposed = false;
}
