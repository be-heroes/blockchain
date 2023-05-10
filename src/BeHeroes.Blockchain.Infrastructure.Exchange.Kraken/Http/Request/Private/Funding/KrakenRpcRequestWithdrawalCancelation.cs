using BeHeroes.Blockchain.Domain.Trading.Model;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private.Funding
{
    public sealed class KrakenRequestWithdrawalCancelation : KrakenRequest
    {
        public KrakenRequestWithdrawalCancelation(Currency currency)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aclass ", currency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawCancel");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
        public KrakenRequestWithdrawalCancelation()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawCancel");
            Method = HttpMethod.Post;
        }
    }
}
