using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.Blockchain.Domain.Trading.ValueObjects;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class TransferRoot : AggregateRoot<Guid>
    {
        private readonly DateTime _created = DateTime.UtcNow;
        private readonly string _currency = string.Empty;
        private readonly double _amount = 0;
        private readonly Guid _senderId = Guid.Empty;
        private readonly Guid _recipientId = Guid.Empty;

        public double Amount => _amount;
        public DateTime Created => _created;
        public Currency? Currency { get; private set; }
        public Guid SenderId => _senderId;
        public Guid RecipientId => _recipientId;

        public TransferRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new TransferCreatedEvent(this));
        }

        public TransferRoot(DateTime created, Currency currency, double amount, AccountRoot sender, AccountRoot recipient) : this()
        {
            _created = created;
            _amount = amount;
            _senderId = sender.Id;
            _recipientId = recipient.Id;
            Currency = currency;

            AddDomainEvent(new TransferUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
