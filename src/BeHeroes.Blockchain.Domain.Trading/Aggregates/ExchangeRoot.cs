using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.CodeOps.Abstractions.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    //TODO: Add markets
    public sealed class ExchangeRoot : AggregateRoot<Guid>
    {
        private readonly DateTime _created = DateTime.UtcNow;
        private readonly string _name = string.Empty;

        public DateTime Created => _created;
        
        public string Name => _name;

        public ExchangeRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new ExchangeCreatedEvent(this));
        }

        public ExchangeRoot(DateTime created, string name) : this()
        {
            _created = created;
            _name = name;

            AddDomainEvent(new ExchangeUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
