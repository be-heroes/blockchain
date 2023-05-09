namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Ticker
    {
        public Market Market;
        public string Timestamp;
        public double Mid;
        public double Last;
        public double LowestAsk;
        public double HighestBid;
        public double PercentChange;
        public double BaseVolume;
        public double QuoteVolume;
        public bool IsFrozen;
        public double Hr24High;
        public double Hr24Low;
    }
}