using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BeHeroes.Blockchain.Domain.Trading.Instruments.Derivatives.Commodities;
using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.ValueObjects
{
    public sealed class OrderNumber : ValueObject, ICommodity
    {
        [Required]
        [JsonPropertyName("identifier")]
        public string Identifier { get; init; } = Core.Cryptography.Utils.Helper.CreateSecureRandomString();

        private OrderNumber() { }

        [JsonConstructor]
        public OrderNumber(string identifier)
        {
            Identifier = identifier;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Identifier;
        }
    }
}