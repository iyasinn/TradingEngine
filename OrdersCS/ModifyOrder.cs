using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class ModifyOrder : IOrderCore
    {
        // DOnt ned isBuySide right now but could be used later 
        public ModifyOrder(IOrderCore orderCore, long price, uint quantity, bool isBuySide)
        {

            Price = price;
            Quantity = quantity; 
            IsBuySide = isBuySide;

            // FIELDS
            _ordercore = orderCore;

            // modify order is a new order and a cancel order 
            // need to generate a new order and genrate a cancel order 
        }

        public CancelOrder ToCancelOrder()
        {
            //return new CancelOrder(_ordercore);
            // Can just pass in this as it works better
            return new CancelOrder(this);
        }

        public Order ToNewOrder()
        {
            //return new NewOrder(_ordercore, Price, Quantity, IsBuySide);
            // No consturctor of NewOrder that doesnt make a newOrder core
            return new Order(this);
        }

        public long Price { get; private set; }
        public uint Quantity { get; private set;  }
        public bool IsBuySide { get; private set; }

        public long OrderId => _ordercore.OrderId;
        public string Username => _ordercore.Username;
        public int SecurityId => _ordercore.SecurityId;

        public CancelOrder cancel { get; private set; }
        public Order add { get; private set; }  

        private readonly IOrderCore _ordercore;
        
    }
}
