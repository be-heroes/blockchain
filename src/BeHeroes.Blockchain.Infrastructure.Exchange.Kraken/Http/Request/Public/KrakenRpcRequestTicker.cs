using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestTicker : KrakenRequest
    {
        public KrakenRequestTicker(List<MarketRoot> markets )
        {
            string pair = "";
            foreach (var market in markets)
            {
                pair += market.BaseCurrency?.Name + market.QuoteCurrency?.Name + ",";
            }
            pair = pair.Remove(pair.Length-1);         
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", pair),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/public/Ticker");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
