using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class TradeAction : EntityEnumeration
    {
        public readonly static TradeAction Unknown = new TradeAction(1, nameof(Unknown).ToLowerInvariant());
        public readonly static TradeAction Hold = new TradeAction(2, nameof(Hold).ToLowerInvariant());
        public readonly static TradeAction Buy = new TradeAction(3, nameof(Buy).ToLowerInvariant());
        public readonly static TradeAction Sell = new TradeAction(4, nameof(Sell).ToLowerInvariant());

        public TradeAction(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<TradeAction> List()
        {
            var result = new List<TradeAction>
            {
                Unknown,
                Hold,
                Buy,
                Sell
            };

            return result.AsEnumerable();
        }
    }
}