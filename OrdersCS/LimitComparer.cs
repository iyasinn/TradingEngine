using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class BidLimitComparer : IComparer<Limit>
    {
        // Dont need to make copy constructors of this class now
        public static IComparer<Limit> Comparer { get; } = new BidLimitComparer();

        public int Compare(Limit x, Limit y)
        {
            if (x.Price == y.Price)
            {
                return 0;
            }
            else if (x.Price > y.Price)
            {
                return -1; 
            }
            else
            {
                return 1; 
            }
        }
    }

    public class AskLimitComparer : IComparer<Limit>
    {

        public static IComparer<Limit> Comparer { get; } = new AskLimitComparer();

        public int Compare(Limit x, Limit y)
        {
            if (x.Price == y.Price)
            {
                return 0;
            }
            // So now 1 means we prirotize x.price
            // So now this is ascending
            else if (x.Price > y.Price)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }

}
