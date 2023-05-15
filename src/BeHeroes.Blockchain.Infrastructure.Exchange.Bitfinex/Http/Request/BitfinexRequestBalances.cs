using System.Globalization;
using System.Net.Http.Json;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRequestBalances : BitfinexRequest
    {
        public BitfinexRequestBalances()
        {
            RequestUri = new Uri($"https://api.bitfinex.com/v1/balances");
            Method = HttpMethod.Post;                       
            Content = JsonContent.Create(new {
                    request = RequestUri.AbsolutePath,
                    nonce = TimeStamp.Ticks.ToString(CultureInfo.InvariantCulture)
            });
        }
    }
}