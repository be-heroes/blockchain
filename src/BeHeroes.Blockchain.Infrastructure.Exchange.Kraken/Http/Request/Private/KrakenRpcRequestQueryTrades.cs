namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestQueryTrades : KrakenRequest
    {
        public KrakenRequestQueryTrades()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/QueryTrades");
            Method = HttpMethod.Post;
        }
    }
}
