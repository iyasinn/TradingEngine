using System;

namespace TradingEngineServer.Instrument
{
    public class Security
    {

        public string ticker { get; private set; }

        public int totalQuantity { get; private set; }

        public Security(string tickerIn) {
            ticker = tickerIn; 
        }


    }
}
