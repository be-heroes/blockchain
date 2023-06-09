using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestOrderBook : KrakenRequest
    {
        public KrakenRequestOrderBook(List<MarketRoot> markets, int count)
        {
            string pair = "";
            foreach (var market in markets)
            {
                pair += market.BaseCurrency?.Name + market.QuoteCurrency?.Name + ",";
            }
            pair = pair.Remove(pair.Length - 1);
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", pair),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            if (count > 1)
            {
                postData.Add(new KeyValuePair<string, string>("count", count.ToString()));
            }


            RequestUri = new Uri("https://api.kraken.com/0/public/Depth");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
        public KrakenRequestOrderBook(MarketRoot market, int count)
        {
            string pair = market.BaseCurrency?.Name + market.QuoteCurrency?.Name;
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", pair),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            if (count > 0)
            {
                postData.Add(new KeyValuePair<string, string>("count", count.ToString()));
            }


            RequestUri = new Uri("https://api.kraken.com/0/public/Depth");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
