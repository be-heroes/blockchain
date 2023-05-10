namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Public
{
    public sealed class KrakenRequestAssetPairs : KrakenRequest
    {
        public KrakenRequestAssetPairs()
        {
            RequestUri = new Uri("https://api.kraken.com/0/public/AssetPairs");
            Method = HttpMethod.Post;
        }
    }
}
