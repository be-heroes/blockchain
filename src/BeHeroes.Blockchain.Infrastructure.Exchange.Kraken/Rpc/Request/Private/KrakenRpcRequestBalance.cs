using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestBalance : KrakenRpcRequest
    {
        public KrakenRpcRequestBalance()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/Balance");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            });
        }
    }
}
