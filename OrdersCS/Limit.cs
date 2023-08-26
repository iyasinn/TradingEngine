using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class Limit
    {

        public Limit(long price)
        {
            Price = price;
        }

        public long Price { get; private set; }
        public OrderBookEntry Head { get; set; }
        public OrderBookEntry Tail { get; set; }

        public bool isEmpty()
        {
            // Don't need tail part but for sake of being safe
            return Head == null && Tail == null; 
        }

        // O(N)
        public uint GetlevelOrderCount()
        {
            uint orderCount = 0;
            OrderBookEntry headPointer = Head; 
            while (headPointer != null)
            {
                if (headPointer.CurrentOrder.CurrentQuantity!= 0)
                {
                    orderCount++; 
                }
          
                headPointer = headPointer.Next; 
            }
            return orderCount; 
        }

        // O(N)
        public uint GetLevelOrderQuantity()
        {
            uint orderQuantity = 0;
            OrderBookEntry headPointer = Head; 
            while (headPointer != null)
            {
                orderQuantity += headPointer.CurrentOrder.CurrentQuantity;
            }
            return orderQuantity; 
        }

        public List<OrderRecord> GetLevelOrderRecords()
        {

            List<OrderRecord> orderRecords = new List<OrderRecord>();

            OrderBookEntry headPointer = Head;
            uint theoreticalQueuePosition = 0; 

            while (Head != null)
            {
                var currentOrder = headPointer.CurrentOrder;
                if (currentOrder.CurrentQuantity != 0) {

                    orderRecords.Add(new OrderRecord(currentOrder.OrderId, currentOrder.CurrentQuantity, currentOrder.Price, currentOrder.IsBuySide, currentOrder.Username, currentOrder.SecurityId, theoreticalQueuePosition));
                }

                // Always increment theoretical Queu position because that is where we are at theoretically even if our order has 0 quantity 
                theoreticalQueuePosition++;
                headPointer = headPointer.Next; 
            }

            return orderRecords; 

        }

        // How does this work??????
        // It's a variable after all 
        public Side Side
        {
            // This is run whenever we run Side
            get
            { 
                if (isEmpty())
                {
                    return Side.Unknown;
                }
                else
                {
                    return Head.CurrentOrder.IsBuySide ? Side.Bid : Side.Ask;
                }
            }

        }



    }
}
