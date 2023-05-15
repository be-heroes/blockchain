using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class MarketCreatedEvent : AggregateRootEvent<MarketRoot>
    {
        public MarketCreatedEvent(MarketRoot market) : base(market)
        {
        }
    }
}