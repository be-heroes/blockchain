namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private.Funding
{
    public sealed class KrakenRequestDepositMethods : KrakenRequest
    {
        public KrakenRequestDepositMethods()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/DepositMethods");
            Method = HttpMethod.Post;
        }
    }
}
