using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class CancelOrder : IOrderCore 
    {
        public CancelOrder(IOrderCore orderCore) {
            // FIELDS
            // Learn the difference between fields/propreties etc 
            _ordercore = orderCore;
        }

        public long OrderId => _ordercore.OrderId;
        public string Username => _ordercore.Username;
        public int SecurityId => _ordercore.SecurityId;


        private readonly IOrderCore _ordercore;
    }
}
