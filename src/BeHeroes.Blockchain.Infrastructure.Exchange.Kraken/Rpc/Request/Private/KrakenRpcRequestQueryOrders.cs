using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestQueryOrders : KrakenRpcRequest
    {
        public KrakenRpcRequestQueryOrders()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/QueryOrders");
            Method = HttpMethod.Post;
        }
    }
}
