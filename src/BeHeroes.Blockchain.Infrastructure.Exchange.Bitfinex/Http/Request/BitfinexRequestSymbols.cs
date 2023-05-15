namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRpcRequestSymbols : BitfinexRequest
    {
        public BitfinexRpcRequestSymbols(string symbol = "BTCUSD")
        {
            RequestUri = new Uri($"https://api.bitfinex.com/v1/symbols");
            Method = HttpMethod.Get;
        }
    }
}