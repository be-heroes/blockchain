using BeHeroes.Blockchain.Domain.Trading.ValueObjects;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestAccountTradeBalance : KrakenRequest
    {
        public KrakenRequestAccountTradeBalance(Currency currency)
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
