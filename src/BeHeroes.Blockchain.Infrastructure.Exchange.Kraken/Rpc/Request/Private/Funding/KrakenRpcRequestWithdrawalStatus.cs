using System;
using System.Collections.Generic;
using System.Net.Http;
using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Private.Funding
{
    public sealed class KrakenRpcRequestWithdrawalStatus : KrakenRpcRequest
    {
        public KrakenRpcRequestWithdrawalStatus(Currency currency)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aclass ", currency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawStatus");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
        public KrakenRpcRequestWithdrawalStatus()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawStatus");
            Method = HttpMethod.Post;
        }
    }
}
