using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
using BeHeroes.CodeOps.Abstractions.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class MarketRoot : AggregateRoot<Guid>
    {
        private readonly DateTime _created = DateTime.UtcNow;
        private readonly bool _isActive = false;

        public DateTime Created => _created;

        public string Name => $"{BaseCurrency?.Name}-{QuoteCurrency?.Name}";

        public Currency? BaseCurrency { get; private set; }

        public Currency? QuoteCurrency { get; private set; }
        
        public bool IsActive => _isActive;

        public MarketRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new MarketCreatedEvent(this));
        }

        public MarketRoot(DateTime created, Currency baseCurrency, Currency quoteCurrency, bool isActive) : this()
        {
            _created = created;
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
            _isActive = isActive;

            AddDomainEvent(new MarketUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
