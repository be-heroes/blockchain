namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestAssets : KrakenRequest
    {
        public KrakenRequestAssets()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/Assets");
            Method = HttpMethod.Post;
        }
    }
}
