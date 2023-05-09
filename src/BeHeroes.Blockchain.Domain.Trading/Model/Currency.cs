using System.Text.Json.Serialization;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Currency
    {

        public Currency(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Currency(string id)
        {
            Id = id;
            Name = id;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}
