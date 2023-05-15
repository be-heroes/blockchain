using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private.Trade
{
    public sealed class KrakenRequestCancelOrder : KrakenRequest
    {
        public KrakenRequestCancelOrder(OrderRoot order)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("txid ", order.OrderNumber?.Identifier ?? string.Empty),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };
            RequestUri = new Uri("https://api.kraken.com/0/private/CancelOrder");
            Method = HttpMethod.Post;
        }
    }
}
