using System.Text.Json.Serialization;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class MarketVolume
    {
        [JsonPropertyName("Market")]
        public Market Market { get; set; }
        [JsonPropertyName("BaseVolume")]
        public double Volume24HourBase { get; set; }
        [JsonPropertyName("QuoteVolume")]
        public double Volume24HourQuote { get; set; }
    }
}
