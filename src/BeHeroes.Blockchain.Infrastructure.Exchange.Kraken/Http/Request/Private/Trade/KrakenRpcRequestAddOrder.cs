using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private.Trade
{
    public sealed class KrakenRequestAddOrder : KrakenRequest
    {
        public KrakenRequestAddOrder(Market market, string type, double price, double volume)
        {
            // TODO Add Parameters
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };
            RequestUri = new Uri("https://api.kraken.com/0/private/AddOrder");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
