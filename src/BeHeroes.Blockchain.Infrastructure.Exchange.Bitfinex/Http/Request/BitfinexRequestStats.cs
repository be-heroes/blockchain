namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRpcRequestStats : BitfinexRequest
    {
        public BitfinexRpcRequestStats(string symbol = "BTCUSD")
        {
            RequestUri = new Uri($"https://api.bitfinex.com/v1/stats/{symbol}");
            Method = HttpMethod.Get;
        }
    }
}