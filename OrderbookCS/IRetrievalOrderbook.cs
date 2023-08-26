using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    // This lets us not only modify the state of the orderbook, but it also lets us retrivee contents of the orderbook and brin gi outside the orderbook 
    // It's a dangerous thing to do, but we have this just in case we need it 

    // THIRRD HIGHEST 
    public interface IRetrievalOrderbook : IOrderEntryOrderbook
    {
        List<OrderBookEntry> GetAskOrders(); 
        List<OrderBookEntry> GetBidOrders();

    }
}
