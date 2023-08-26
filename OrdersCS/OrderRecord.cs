using System;
using System.Collections.Generic;
using System.Text;


namespace TradingEngineServer.Orders
{
    // A record API
    // Read only representation of an order
    // Theoreitical queue position for levle 4 ppl I think
    // Or like, its theroteically wher eyou are at
    // Quite useful for algorithmic traders 
    public record OrderRecord (long OrderId, uint Quantity, long Price, bool isBuySide, string Username, int SecurityId, uint TheoreticalQueuePostion);
}

// This is here temporarily to enable record types in C#9 due to a visual studio 2019 bug 
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}