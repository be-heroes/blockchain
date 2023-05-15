using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class OrderCreatedEvent : AggregateRootEvent<OrderRoot>
    {
        public OrderCreatedEvent(OrderRoot order) : base(order)
        {
        }
    }
}