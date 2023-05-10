namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestTime : KrakenRequest
    {
        public KrakenRequestTime()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/Time");
            Method = HttpMethod.Post;
        }
    }
}
