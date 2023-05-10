namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestClosedOrders : KrakenRequest
    {
        public KrakenRequestClosedOrders()
        {

            RequestUri = new Uri("https://api.kraken.com/0/private/ClosedOrders");
            Method = HttpMethod.Post;
        }
    }
}
