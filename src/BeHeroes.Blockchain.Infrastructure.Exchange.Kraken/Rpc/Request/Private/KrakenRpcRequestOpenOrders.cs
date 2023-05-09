using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestOpenOrders : KrakenRpcRequest
    {
        public KrakenRpcRequestOpenOrders()
        {

            RequestUri = new Uri("https://api.kraken.com/0/private/OpenOrders");
            Method = HttpMethod.Post;
        }
    }
}
