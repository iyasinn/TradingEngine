using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TradingEngineServer.Logging
{
    public interface ILogger
    {
        // module is where it is called from
        // We have exception because we might pass in an exception message
        void Debug(string module, string message);
        void Debug(string module, Exception exception);
        void Information(string module, string message);
        void Information(string module, Exception exception);
        void Warning(string module, string message);
        void Warning(string module, Exception exception);

        void Error(string module, string message);
        void Error(string module, Exception exception);

        // We will have an abstract logger that funnels all the methods into one method, which will do the right type of logging
        // So these will all go to one type of method

    }
}
