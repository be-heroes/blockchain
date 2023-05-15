using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class TransferUpdatedEvent : AggregateRootEvent<TransferRoot>
    {
        public TransferUpdatedEvent(TransferRoot transfer) : base(transfer)
        {
        }
    }
}