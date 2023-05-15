using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class OrderUpdatedEvent : AggregateRootEvent<OrderRoot>
    {
        public OrderUpdatedEvent(OrderRoot order) : base(order)
        {
        }
    }
}