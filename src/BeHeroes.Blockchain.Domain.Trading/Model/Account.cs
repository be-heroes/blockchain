using System.Text.Json.Serialization;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Account
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("wallet")]
        public string Wallet { get; set; }
    }
}
