namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request
{
    public class KrakenRequest : HttpRequestMessage
    {
        public DateTime TimeStamp => DateTime.Now;
    }
}
