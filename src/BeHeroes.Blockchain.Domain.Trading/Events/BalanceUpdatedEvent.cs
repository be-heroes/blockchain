using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class BalanceUpdatedEvent : AggregateRootEvent<BalanceRoot>
    {
        public BalanceUpdatedEvent(BalanceRoot balance) : base(balance)
        {
        }
    }
}