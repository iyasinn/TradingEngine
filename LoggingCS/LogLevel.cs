using System;

namespace TradingEngineServer.Logging
{
    // Log levels 
    // We want to be able to call things like
    // log.inforamtion, log.error, etc
    public enum LogLevel
    {
        Debug, 
        Information,
        Warning, 
        Error, 
    }
}
