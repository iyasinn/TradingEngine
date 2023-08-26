using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orders;

// Making a separate namespace within this project
namespace TradingEngineServer.Rejects
{
    public class Rejection
    {
        public Rejection(IOrderCore rejectedOrder, RejectionReason rejectionReason)
        {
            _orderCore = rejectedOrder;
            Reason = rejectionReason;

        }


        public RejectionReason Reason { get; private set; }
        public long OrderId { get; private set; }
        public string Username { get; private set; }
        public int SecurityId { get; private set; }

        private readonly IOrderCore _orderCore;
    }
}
