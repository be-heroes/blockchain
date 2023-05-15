using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class AccountCreatedEvent : AggregateRootEvent<AccountRoot>
    {
        public AccountCreatedEvent(AccountRoot account) : base(account)
        {
        }
    }
}