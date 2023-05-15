using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestTradeVolume : KrakenRequest
    {
        public KrakenRequestTradeVolume(List<MarketRoot> markets, bool feeInfo)
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

            if (feeInfo)
            {
                postData.Add(new KeyValuePair<string, string>("fee-info", feeInfo.ToString()));
            }

            RequestUri = new Uri("https://api.kraken.com/0/private/TradeVolume");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
