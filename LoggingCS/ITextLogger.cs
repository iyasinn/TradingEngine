using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    // Our ITextLogger is an ILogger
    // IDsiposable is for any class where you need to free up resources
    // So this is goodt o have 
    public interface ITextLogger : ILogger, IDisposable
    {

    }
}
