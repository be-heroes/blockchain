using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Events
{
    public sealed class TransferCreatedEvent : AggregateRootEvent<TransferRoot>
    {
        public TransferCreatedEvent(TransferRoot transfer) : base(transfer)
        {
        }
    }
}