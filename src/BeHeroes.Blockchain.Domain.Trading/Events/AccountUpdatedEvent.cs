using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class AccountUpdatedEvent : AggregateRootEvent<AccountRoot>
    {
        public AccountUpdatedEvent(AccountRoot account) : base(account)
        {
        }
    }
}