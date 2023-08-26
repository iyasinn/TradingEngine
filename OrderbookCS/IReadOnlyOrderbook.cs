using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orderbook
{
    // HIGHEST LEVEL 
    public interface IReadOnlyOrderbook
    {
        bool containsOrder(long orderid);

        OrderbookSpread GetSpread(); 

        int Count { get; }


    }
}
