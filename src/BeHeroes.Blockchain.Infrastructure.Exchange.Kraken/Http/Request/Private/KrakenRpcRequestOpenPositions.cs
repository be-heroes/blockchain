namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestOpenPositions : KrakenRequest
    {
        public KrakenRequestOpenPositions()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/OpenPositions");
            Method = HttpMethod.Post;
        }
    }
}
