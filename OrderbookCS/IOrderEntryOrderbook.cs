using System;
using TradingEngineServer.Orders;
    
namespace TradingEngineServer.Orderbook
{
    // The one we can change actuallyr eads from the ReadOnlyOne
    // we also want an interface with even more authority
    // we have AUTHORIEITES for our order books 
    // A write only interface to change the state of the orderbook is what we have here

    // SECOND HIGHEST 
    public interface IOrderEntryOrderbook : IReadOnlyOrderbook
    {
        // Can add things like cancel all as well 
        void AddOrder(Order order);
        void ChangeOrder(ModifyOrder order);
        void RemoveOrder(CancelOrder order);

    }
}
