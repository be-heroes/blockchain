using BeHeroes.Blockchain.Domain.Trading.Aggregates;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRpcRequestTicker : BitfinexRequest
    {
        public BitfinexRpcRequestTicker(MarketRoot market)
        {
            RequestUri = new Uri($"https://api.bitfinex.com/v1/pubticker/"+market.QuoteCurrency?.Name+market.BaseCurrency?.Name);
            Method = HttpMethod.Get;
        }

    }
}