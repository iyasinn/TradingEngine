using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    // THIS IS A NEW ORDER 
    public class Order : IOrderCore
    {
        // You cant have negative quantities, but you can have negative prices in spread insstruments, in comodieis ets. 
        public Order(IOrderCore ordercore, long price, uint quantity, bool isBuySide)
        {

            // PROPERTIES
            Price = price; 
            InitialQuantity = quantity;
            CurrentQuantity = quantity;
            IsBuySide = isBuySide;

            // FIELDS
            _ordercore = ordercore;
        }

        // this just means the constructor of ModifyOrder
        // order is a modify order which is a IOrderCore, and the first field requires an IOrderCore, so this works just fine
        // so all the variables get set too 
        // Callin the above constructor
        public Order(ModifyOrder order) : this(order, order.Price, order.Quantity, order.IsBuySide) 
        {
        }

        public long Price { get; private set; } 
        public uint InitialQuantity { get; private set; }
        public uint CurrentQuantity { get; private set; }
        public bool IsBuySide { get; private set; }

        // Delegating to get this from the inherited class
        public long OrderId => _ordercore.OrderId;
        public string Username => _ordercore.Username;
        public int SecurityId => _ordercore.SecurityId;
        // This works fine too
        //public int SecurityID { get => _ordercore.SecurityId; }


        // METHODS
        public void IncreaseQuantity(uint quantityDelta)
        {
            CurrentQuantity += quantityDelta;
        }

        public void DecreaseQuantity(uint quantityDelta)
        {
            // Current Quantity might go to 0 and underflow
            //CurrentQuantity -= quantityDelta;
            if (quantityDelta > CurrentQuantity)
            {
                throw new InvalidOperationException($"Quantity Delta > Current Quantity for OrderID={OrderId}");
            }
            CurrentQuantity = Math.Min(CurrentQuantity, CurrentQuantity - quantityDelta);
        }


        // FIELDS
        // Time 
        // Type of order
        // Price of order
        // Quanity of order
        // ORder core is the simple order data we ALWAYS NEED
        // Use _ for private readonly? 
        private readonly IOrderCore _ordercore;
    }
}
