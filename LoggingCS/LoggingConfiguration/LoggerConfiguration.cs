using System;
using System.Collections.Generic;
using System.Text;


namespace TradingEngineServer.Logging.LoggingConfiguration
{
    // This needs to have a configuration for a text logger and also for other things
     public class LoggerConfiguration
    {
        // How do we know which config to use?
        // We will specify what sort of loggin configuration we will specify, aka by using the logger type

        public LoggerType loggerType { get; set; }

        public DatabaseLoggerConfiguration databaseLoggerConfiguration { get; set; }

        public TextLoggerConfiguration textLoggerConfiguration { get; set; }
    }

    public class DatabaseLoggerConfiguration
    {

    }

    public class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string Filename { get; set; }
        public string FileExtension { get; set; }
    }
}
