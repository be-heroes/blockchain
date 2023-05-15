using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestOHLC : KrakenRequest
    {
        public KrakenRequestOHLC(List<MarketRoot> markets, int interval, DateTime since )
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
                new KeyValuePair<string, string>("since", since.Ticks.ToString()),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            if (interval > 1)
            {
                postData.Add(new KeyValuePair<string, string>("interval", interval.ToString()));
            }

            RequestUri = new Uri("https://api.kraken.com/0/public/OHLC");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
