using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.Aggregates
{
    public sealed class OrderType : EntityEnumeration
    {
        public readonly static OrderType Unknown = new OrderType(1, nameof(Unknown).ToLowerInvariant());
        public readonly static OrderType Buy = new OrderType(2, nameof(Buy).ToLowerInvariant());
        public readonly static OrderType Sell = new OrderType(3, nameof(Sell).ToLowerInvariant());

        public OrderType(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<OrderType> List()
        {
            var result = new List<OrderType>
            {
                Unknown,
                Buy,
                Sell
            };

            return result.AsEnumerable();
        }
    }
}