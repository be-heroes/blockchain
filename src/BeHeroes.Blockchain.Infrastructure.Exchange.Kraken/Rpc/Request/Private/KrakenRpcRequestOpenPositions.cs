using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestOpenPositions : KrakenRpcRequest
    {
        public KrakenRpcRequestOpenPositions()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/OpenPositions");
            Method = HttpMethod.Post;
        }
    }
}
