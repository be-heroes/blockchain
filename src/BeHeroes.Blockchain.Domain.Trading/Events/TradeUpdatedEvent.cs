using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class TradeUpdatedEvent : AggregateRootEvent<TradeRoot>
    {
        public TradeUpdatedEvent(TradeRoot trade) : base(trade)
        {
        }
    }
}