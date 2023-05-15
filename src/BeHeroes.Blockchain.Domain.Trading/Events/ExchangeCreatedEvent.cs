using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class ExchangeCreatedEvent : AggregateRootEvent<ExchangeRoot>
    {
        public ExchangeCreatedEvent(ExchangeRoot exchange) : base(exchange)
        {
        }
    }
}