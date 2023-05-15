using System.ComponentModel.DataAnnotations;
using BeHeroes.Blockchain.Domain.Trading.Events;
using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
using BeHeroes.CodeOps.Abstractions.Aggregates;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    //TODO: Add trades
    public sealed class OrderRoot : AggregateRoot<Guid>
    {
        private readonly double _amountUnfilled = 0;
        private readonly DateTime _created = DateTime.UtcNow;
        private OrderType _orderType = OrderType.Unknown;
        private int _orderTypeId = OrderType.Unknown.Id;

        public double AmountUnfilled => _amountUnfilled;

        public DateTime Created => _created;

        public Currency? Currency { get; private set; }

        public OrderNumber? OrderNumber { get; private set; }

        public OrderType OrderType
        {
            get
            {
                return _orderType;
            }
            private set
            {
                _orderType = value;
                _orderTypeId = _orderType.Id;
            }
        }

        public OrderRoot()
        {                        
            // We need to record this event due the EF conventions related to entity constructors
            AddDomainEvent(new OrderCreatedEvent(this));
        }

        public OrderRoot(DateTime created, Currency currency, OrderNumber orderNumber, OrderType orderType, double amount) : this()
        {
            _created = created;            
            _amountUnfilled = amount;
            OrderNumber = orderNumber;
            OrderType = orderType;
            Currency = currency;

            AddDomainEvent(new OrderUpdatedEvent(this));
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
