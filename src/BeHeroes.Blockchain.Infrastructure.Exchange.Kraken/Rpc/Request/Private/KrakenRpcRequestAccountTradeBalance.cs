using System;
using System.Collections.Generic;
using System.Net.Http;
using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private
{
    public sealed class KrakenRpcRequestAccountTradeBalance : KrakenRpcRequest
    {
        public KrakenRpcRequestAccountTradeBalance(Currency currency)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                //new KeyValuePair<string, string>("aclass ", Currency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/private/TradeBalance");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
