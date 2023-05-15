using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class ExchangeUpdatedEvent : AggregateRootEvent<ExchangeRoot>
    {
        public ExchangeUpdatedEvent(ExchangeRoot exchange) : base(exchange)
        {
        }
    }
}