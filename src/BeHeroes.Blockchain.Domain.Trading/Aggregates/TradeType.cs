using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class TradeType : EntityEnumeration
    {
        public readonly static TradeType Unknown = new TradeType(1, nameof(Unknown).ToLowerInvariant());
        public readonly static TradeType Spot = new TradeType(2, nameof(Spot).ToLowerInvariant());
        public readonly static TradeType Market = new TradeType(3, nameof(Market).ToLowerInvariant());
        public readonly static TradeType Futures = new TradeType(4, nameof(Futures).ToLowerInvariant());

        public TradeType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<TradeType> List()
        {
            var result = new List<TradeType>
            {
                Unknown,
                Spot,
                Market,
                Futures
            };

            return result.AsEnumerable();
        }
    }
}