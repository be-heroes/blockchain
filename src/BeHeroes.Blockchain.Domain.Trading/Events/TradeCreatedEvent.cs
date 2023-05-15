using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class TradeCreatedEvent : AggregateRootEvent<TradeRoot>
    {
        public TradeCreatedEvent(TradeRoot trade) : base(trade)
        {
        }
    }
}