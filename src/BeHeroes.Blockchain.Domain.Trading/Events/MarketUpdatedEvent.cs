using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class MarketUpdatedEvent : AggregateRootEvent<MarketRoot>
    {
        public MarketUpdatedEvent(MarketRoot market) : base(market)
        {
        }
    }
}