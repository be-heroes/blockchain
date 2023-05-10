namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestBalance : KrakenRequest
    {
        public KrakenRequestBalance()
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
