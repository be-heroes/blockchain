using System;
using System.Collections.Generic;
using System.Net.Http;
using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request.Public
{
    public sealed class KrakenRpcRequestRecentTrades : KrakenRpcRequest
    {
        public KrakenRpcRequestRecentTrades(Market market, long since)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.BaseCurrency.Name+market.QuoteCurrency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString()),
                new KeyValuePair<string, string>("since", since.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/public/Trades");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }

        public KrakenRpcRequestRecentTrades(Market market)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("pair", market.BaseCurrency.Name+market.QuoteCurrency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/public/Trades");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
