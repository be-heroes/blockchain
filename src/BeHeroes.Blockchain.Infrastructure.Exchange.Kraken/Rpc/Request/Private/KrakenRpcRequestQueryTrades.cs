using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestQueryTrades : KrakenRpcRequest
    {
        public KrakenRpcRequestQueryTrades()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/QueryTrades");
            Method = HttpMethod.Post;
        }
    }
}
