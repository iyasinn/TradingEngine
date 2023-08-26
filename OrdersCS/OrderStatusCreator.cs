using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    // sealed means no inherteince
    public sealed class OrderStatusCreator
    {
        public static CancelOrderStatus GenerateCancelOrderStatus(CancelOrder co)
        {
            return new CancelOrderStatus();
        }

        public static NewOrderStatus GenerateNewOrderStatus(Order no)
        {
            return new NewOrderStatus();
        }

        public static ModifyOrderStatus GenerateModifyOrderStatus(ModifyOrder mo)
        {
            return new ModifyOrderStatus();
        }

    }
}
