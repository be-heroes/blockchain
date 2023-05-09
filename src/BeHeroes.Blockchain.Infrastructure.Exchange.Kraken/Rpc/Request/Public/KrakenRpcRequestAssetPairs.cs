using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Public
{
    public sealed class KrakenRpcRequestAssetPairs : KrakenRpcRequest
    {
        public KrakenRpcRequestAssetPairs()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/AssetPairs");
            Method = HttpMethod.Post;
        }
    }
}
