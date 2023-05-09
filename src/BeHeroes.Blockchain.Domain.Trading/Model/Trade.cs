using System;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Trade
    {
        public string globalTradeID;
        public string tradeID;
        public DateTime date;
        public string type;
        public double rate;
        public double amount;
        public double total;
    }
}
