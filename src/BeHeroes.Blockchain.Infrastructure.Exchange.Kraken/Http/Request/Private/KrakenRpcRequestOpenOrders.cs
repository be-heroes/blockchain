namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestOpenOrders : KrakenRequest
    {
        public KrakenRequestOpenOrders()
        {

            RequestUri = new Uri("https://api.kraken.com/0/private/OpenOrders");
            Method = HttpMethod.Post;
        }
    }
}
