using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestClosedOrders : KrakenRpcRequest
    {
        public KrakenRpcRequestClosedOrders()
        {

            RequestUri = new Uri("https://api.kraken.com/0/private/ClosedOrders");
            Method = HttpMethod.Post;
        }
    }
}
