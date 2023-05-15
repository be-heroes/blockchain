using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestRecentTrades : KrakenRequest
    {
        public KrakenRequestRecentTrades(MarketRoot market, long since)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.BaseCurrency?.Name+market.QuoteCurrency?.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString()),
                new KeyValuePair<string, string>("since", since.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/public/Trades");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }

        public KrakenRequestRecentTrades(MarketRoot market)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.BaseCurrency?.Name+market.QuoteCurrency?.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/public/Trades");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
