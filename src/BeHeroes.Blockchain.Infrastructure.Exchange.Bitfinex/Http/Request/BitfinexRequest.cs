namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRequest : HttpRequestMessage
    {
        public DateTime TimeStamp => DateTime.Now;
    }
}
