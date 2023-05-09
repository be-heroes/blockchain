using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Public
{
    public sealed class KrakenRpcRequestTime : KrakenRpcRequest
    {
        public KrakenRpcRequestTime()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/Time");
            Method = HttpMethod.Post;
        }
    }
}
