using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BeHeroes.Blockchain.Domain.Trading.Interfaces;
using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.ValueObjects
{
    public sealed class TradeNumber : ValueObject, ICommodity
    {
        [Required]
        [JsonPropertyName("identifier")]
        public string Identifier { get; init; } = Core.Cryptography.Utils.Helper.CreateSecureRandomString();

        private TradeNumber() { }

        [JsonConstructor]
        public TradeNumber(string identifier)
        {
            Identifier = identifier;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Identifier;
        }
    }
}