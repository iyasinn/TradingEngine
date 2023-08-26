using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    // record type, immutable
    // this is unique to C#
    public record LogInformation(LogLevel logLevel, string module, string message, DateTime now, int threadId, string threadName)
    {
    }
}

// This is some weird C# bug, where the record type parameters
// will not work unless we add this
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}
