using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Core.Cryptography.Secp256k1;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.CodeOps.Abstractions.Aggregates;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class AccountRoot : AggregateRoot<Guid>
    {
        private readonly DateTime _created = DateTime.UtcNow;
        private readonly string _name = string.Empty;
        private readonly IKey _publicKey = Secp256k1Key.Empty;

        public DateTime Created => _created;

        public string Name => _name;
        
        public IKey PublicKey => _publicKey;

        public AccountRoot()
        {
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new AccountCreatedEvent(this));
        }

        public AccountRoot(DateTime created, string name, IKey key) : this()
        {
            _created = created;
            _name = name;
            _publicKey = key;
            
            AddDomainEvent(new AccountUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
