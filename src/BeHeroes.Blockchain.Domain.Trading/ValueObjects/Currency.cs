using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BeHeroes.Blockchain.Domain.Trading.Instruments.Derivatives.Commodities;
using BeHeroes.CodeOps.Abstractions.Entities;

namespace BeHeroes.Blockchain.Domain.Trading.ValueObjects
{
    public sealed class Currency : ValueObject, ICommodity
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        [Required]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; init; } = false;

        private Currency() { }

        [JsonConstructor]
        public Currency(string name, bool isActive)
        {
            Name = name;
            IsActive = isActive;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return IsActive;
        }
    }
}