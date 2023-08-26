using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    // This class should be immuatable, so unchanging
    public  interface IOrderCore
    {
        public long OrderId { get; }
        public string Username { get; }
        public int SecurityId { get; }
    }
}
