using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Events;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public abstract class AggregateRootEvent<T> : IDomainEvent where T : IAggregateRoot
    {
        public T Aggregate { get; init; }

        protected AggregateRootEvent(T aggregate)
        {
            Aggregate = aggregate;
        }
    }
}