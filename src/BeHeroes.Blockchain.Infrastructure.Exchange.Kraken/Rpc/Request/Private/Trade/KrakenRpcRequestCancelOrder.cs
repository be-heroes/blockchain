using System;
using System.Collections.Generic;
using System.Net.Http;
using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private.Trade
{
    public sealed class KrakenRpcRequestCancelOrder : KrakenRpcRequest
    {
        public KrakenRpcRequestCancelOrder(Order order)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("txid ", order.OrderNumber),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };
            RequestUri = new Uri("https://api.kraken.com/0/private/CancelOrder");
            Method = HttpMethod.Post;
        }
    }
}
