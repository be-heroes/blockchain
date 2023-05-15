using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
using BeHeroes.CodeOps.Abstractions.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class BalanceRoot : AggregateRoot<Guid>
    {
        private readonly DateTime _created = DateTime.UtcNow;
        private readonly UInt64 _total = 0;

        public DateTime Created => _created;

        public Currency? Currency { get; private set; }
        
        public UInt64 Total => _total;

        public BalanceRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new BalanceCreatedEvent(this));
        }

        public BalanceRoot(DateTime created, Currency currency, UInt64 total) : this()
        {
            _created = created;
            _total = total;
            Currency = currency;

            AddDomainEvent(new BalanceUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
