using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    abstract public class AbstractLogger : ILogger
    {

        // Why do abstract classes have protected consturctors
        protected AbstractLogger() { }

        // Why protected and abstract? 
        // We dont want a body for each of the method calls in ILogger. Instead, they will all go into Log. 
        protected abstract void Log(LogLevel logLevel, string module, string message);

        void ILogger.Debug(string module, string message) => Log(LogLevel.Debug, module, message);

        // Three ways to log an exception
        // exception.Message, but doesnt give call stack
        // or exception.ToString()
        // or $"{exception}"
        void ILogger.Debug(string module, Exception exception) => Log(LogLevel.Debug, module, exception.ToString());


        void ILogger.Information(string module, string message) => Log(LogLevel.Information, module, message);

        void ILogger.Information(string module, Exception exception) => Log(LogLevel.Information, module, exception.ToString());
        void ILogger.Warning(string module, string message) => Log(LogLevel.Warning, module, message);

        void ILogger.Warning(string module, Exception exception) => Log(LogLevel.Warning, module, exception.ToString());

        void ILogger.Error(string module, string message) => Log(LogLevel.Error, module, message);

        void ILogger.Error(string module, Exception exception) => Log(LogLevel.Error, module, exception.ToString());
    }
}
