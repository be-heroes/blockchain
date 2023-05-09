using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Public
{
    public sealed class KrakenRpcRequestAssets : KrakenRpcRequest
    {
        public KrakenRpcRequestAssets()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/Assets");
            Method = HttpMethod.Post;
        }
    }
}
