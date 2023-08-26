using System;
using System.Collections.Generic;
using System.Linq;
using TradingEngineServer.Instrument;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    // We dont want people to have the power to call match 
    // SO we inherent from IREtrieval 
    public class NoMatchOrderbook : IRetrievalOrderbook
    {

        private readonly Security _instrument;

        // We also need a dictionary to see if an order exists in O(1) time 
        // So two places to store it 

        private readonly Dictionary<long, OrderBookEntry> _orders = new Dictionary<long, OrderBookEntry>();

        private readonly SortedSet<Limit> _askLimits = new SortedSet<Limit>(AskLimitComparer.Comparer);
        private readonly SortedSet<Limit> _bidLimits = new SortedSet<Limit>(BidLimitComparer.Comparer);

        // We neeed a couple things for orderbooks
        // Which security it represents 
        public NoMatchOrderbook(Security security)
        {
            _instrument = security;
        }

        public NoMatchOrderbook(string ticker)
        {
            _instrument = new Security(ticker);
        }

        public int Count => _orders.Count;

        // O(1) operation
        public bool containsOrder(long orderid)
        {
            return _orders.ContainsKey(orderid);
        }
      

        public void AddOrder(Order order)
        {
            // adding an order to a limit 
            var baseLimit = new Limit(order.Price);
            AddOrder(order, baseLimit, order.IsBuySide ? _bidLimits : _askLimits, _orders);
        }

        // Probably the most complicated one
        private static void AddOrder(Order order, Limit baseLimit, SortedSet<Limit> limitLevels, Dictionary<long, OrderBookEntry> internalOrderbook)
        {
            if (limitLevels.TryGetValue(baseLimit, out Limit limit))
            {
                OrderBookEntry entry = new OrderBookEntry(order, baseLimit);
                if (limit.Head == null)
                {
                    limit.Head = entry;
                    limit.Tail = entry; 
                }
                else
                {
                    OrderBookEntry tailPointer = limit.Tail;
                    tailPointer.Next = entry;
                    entry.Previous = tailPointer;
                    limit.Tail = entry; 
                }
                internalOrderbook.Add(order.OrderId, entry);
            }
            else
            {
                // No pass by reference issues? 
                limitLevels.Add(baseLimit);
                OrderBookEntry entry = new OrderBookEntry(order, baseLimit);
                baseLimit.Head = entry;
                baseLimit.Tail = entry;
                try
                {
                    internalOrderbook.Add(order.OrderId, entry);
                }
                catch {
                    Console.WriteLine("Countd add to dictoarny");
                }

                Console.WriteLine("Success");
            }
        }

        public void ChangeOrder(ModifyOrder modifyOrder)
        {
            if (_orders.TryGetValue(modifyOrder.OrderId, out OrderBookEntry obe))
            {
                RemoveOrder(modifyOrder.ToCancelOrder());
                AddOrder(modifyOrder.ToNewOrder(), obe.ParentLimit, modifyOrder.IsBuySide ? _askLimits : _bidLimits, _orders);
            }
            else
            {
          
            }
        }

        public void RemoveOrder(CancelOrder cancelOrder)
        {
            if (_orders.TryGetValue(cancelOrder.OrderId, out OrderBookEntry obe))
            {
                // So we found it to remove
                RemoveOrder(cancelOrder, obe, _orders);
            }
        }

        // can change this, dont need cancelOrder, just need
        // order id
        private void RemoveOrder(CancelOrder cancelOrder, OrderBookEntry obe, Dictionary<long, OrderBookEntry> internalBook)
        {
            // Need to rewire teh limit points too
            Limit limi = obe.ParentLimit; 

            if (obe.Previous != null && obe.Next != null)
            {
                obe.Next.Previous = obe.Previous;
                obe.Previous.Next = obe.Next; 
            }
            else if (obe.Previous != null)
            {
                obe.Previous.Next = null;
            }
            else if (obe.Next != null)
            {
                obe.Next.Previous = null; 

            }

            if (obe.ParentLimit.Head == obe && obe.ParentLimit.Tail == obe)
            {
                obe.ParentLimit.Head = null;
                obe.ParentLimit.Tail = null; 
            }
            else if (obe.ParentLimit.Head == obe)
            {
                obe.ParentLimit.Head = obe.Next; 
            }
            else if (obe.ParentLimit.Tail == obe)
            {
                obe.ParentLimit.Tail = obe.Previous; 
            }

            internalBook.Remove(cancelOrder.OrderId);
        }

        public List<OrderBookEntry> GetAskOrders()
        {
            List<OrderBookEntry> orderBookEntries = new List<OrderBookEntry>();
            
            foreach (var askLimit in _askLimits){
                if (askLimit.isEmpty()) continue;
                OrderBookEntry askLimitPointer = askLimit.Head;
                while (askLimitPointer != null)
                {
                    orderBookEntries.Add(askLimitPointer);
                    askLimitPointer = askLimitPointer.Next; 
                }
            }
            return orderBookEntries;
        }

        public List<OrderBookEntry> GetBidOrders()
        {
            List<OrderBookEntry> orderBookEntries = new List<OrderBookEntry>();

            foreach (var bidLimit in _bidLimits)
            {
                if (bidLimit.isEmpty()) continue;
                OrderBookEntry bidLimitPointer = bidLimit.Head;
                while (bidLimitPointer != null)
                {
                    orderBookEntries.Add(bidLimitPointer);
                    bidLimitPointer = bidLimitPointer.Next;
                }
            }
            return orderBookEntries;
        }

        public OrderbookSpread GetSpread()
        {
            long? bestAsk = null;
            long? bestBid = null; 
            // If there is some limit and 
            if (_askLimits.Any() && !_askLimits.Min().isEmpty())
            {
                bestAsk = _askLimits.Min.Price;
            }
            if (_bidLimits.Any() && !_bidLimits.Max().isEmpty())
            {
                bestAsk = _askLimits.Max.Price;
            }
            throw new NotImplementedException();
        }

    }
}
