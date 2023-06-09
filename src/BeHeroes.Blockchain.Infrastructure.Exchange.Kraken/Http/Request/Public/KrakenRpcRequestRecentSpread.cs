using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestRecentSpread : KrakenRequest
    {
        public KrakenRequestRecentSpread(MarketRoot market, long? since)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.BaseCurrency?.Name+market.QuoteCurrency?.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            if (since.HasValue)
                postData.Add(new KeyValuePair<string, string>("since", since.Value.ToString()));

            RequestUri = new Uri("https://api.kraken.com/0/public/Spread");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
