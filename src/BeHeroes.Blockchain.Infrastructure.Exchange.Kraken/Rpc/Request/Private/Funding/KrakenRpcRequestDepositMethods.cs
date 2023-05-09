using System;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private.Funding
{
    public sealed class KrakenRpcRequestDepositMethods : KrakenRpcRequest
    {
        public KrakenRpcRequestDepositMethods()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/DepositMethods");
            Method = HttpMethod.Post;
        }
    }
}
