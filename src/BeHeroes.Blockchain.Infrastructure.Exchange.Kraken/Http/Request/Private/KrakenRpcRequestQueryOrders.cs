namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestQueryOrders : KrakenRequest
    {
        public KrakenRequestQueryOrders()
        {
            RequestUri = new Uri("https://api.kraken.com/0/private/QueryOrders");
            Method = HttpMethod.Post;
        }
    }
}
