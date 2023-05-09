using System.Text.Json.Serialization;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Exchange
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("markets")]
        public List<Market> Markets { get; private set; }
    }
}
