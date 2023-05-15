using BeHeroes.Blockchain.Domain.Trading.ValueObjects;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private.Funding
{
    public sealed class KrakenRequestWithdrawalInformation : KrakenRequest
    {
        public KrakenRequestWithdrawalInformation(Currency currency)
        {
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("aclass ", currency.Name),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawInfo");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }

        public KrakenRequestWithdrawalInformation()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/WithdrawInfo");
            Method = HttpMethod.Post;
        }
    }
}
