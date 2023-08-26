using System;

namespace TradingEngineServer.Orders
{
    public class OrderCore : IOrderCore
    {
        public OrderCore(long orderIdIn, string usernameIn, int securityIdIn)
        {
            OrderId = orderIdIn;
            Username = usernameIn;
            SecurityId = SecurityId;
        }

        public long OrderId { get; private set; }
        public string Username { get; private set; }
        public int SecurityId { get; private set; }
    }
}
