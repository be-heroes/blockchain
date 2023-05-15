using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class BalanceCreatedEvent : AggregateRootEvent<BalanceRoot>
    {
        public BalanceCreatedEvent(BalanceRoot balance) : base(balance)
        {
        }
    }
}