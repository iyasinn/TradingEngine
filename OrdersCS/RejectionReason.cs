using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public enum RejectionReason
    {
        // Default is Unknown
        Unknown, 
        OrderNotFound, 
        // Like wrong order object is nto found 
        InstrumentNotFound, 
        AttempingToModifyWrongSide, 
        Unauthorized,
    }
}
