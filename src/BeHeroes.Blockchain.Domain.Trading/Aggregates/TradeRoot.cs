using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
using BeHeroes.CodeOps.Abstractions.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class TradeRoot : AggregateRoot<Guid>
    {
        private readonly double _amount = 0;
        private readonly DateTime _created = DateTime.UtcNow;
        private TradeType _tradeType = TradeType.Unknown;
        private int _tradeTypeId = TradeType.Unknown.Id;
        private TradeAction _tradeAction = TradeAction.Unknown;
        private int _tradeActionId = TradeAction.Unknown.Id;

        public DateTime Created => _created;

        public double Amount => _amount;

        public Currency? Currency { get; private set; }

        public TradeNumber? TradeNumber { get; private set; }

        public TradeType TradeType
        {
            get
            {
                return _tradeType;
            }
            private set
            {
                _tradeType = value;
                _tradeTypeId = _tradeType.Id;
            }
        }

        public TradeAction ActionType
        {
            get
            {
                return _tradeAction;
            }
            private set
            {
                _tradeAction = value;
                _tradeActionId = _tradeAction.Id;
            }
        }

        public TradeRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new TradeCreatedEvent(this));
        }

        public TradeRoot(DateTime created, Currency currency, TradeNumber tradeNumber, TradeAction tradeAction, TradeType tradeType, double amount) : this()
        {
            _created = created;
            _amount = amount;
            ActionType = tradeAction;
            Currency = currency;
            TradeNumber = tradeNumber;
            TradeType = tradeType;

            AddDomainEvent(new TradeUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
