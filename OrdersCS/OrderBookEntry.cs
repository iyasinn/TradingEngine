using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class OrderBookEntry
    {

        // Better to have {get; init} where we only intiize in the constructor 
        public OrderBookEntry(Order currentOrder, Limit parentLimit)
        {
            // Universal creation time is standardized
            CreationTime = DateTime.UtcNow;
            ParentLimit = parentLimit;
            CurrentOrder = currentOrder; 
        }

        public Order CurrentOrder { get; private set; }

        public DateTime CreationTime { get; private set; }

        public Limit ParentLimit { get; private set; }

        public OrderBookEntry Next { get; set;  }

        public OrderBookEntry Previous { get; set; }    

    }


}
