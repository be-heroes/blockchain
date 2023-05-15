using System.Globalization;
using System.Net.Http.Json;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request
{
    public class BitfinexRequestAccountInfo : BitfinexRequest
    {
        public BitfinexRequestAccountInfo()
        {
            RequestUri = new Uri("https://api.bitfinex.com/v1/account_infos");
            Method = HttpMethod.Post;            
            Content = JsonContent.Create(new {
                    request = RequestUri.AbsolutePath,
                    nonce = TimeStamp.Ticks.ToString(CultureInfo.InvariantCulture)
            });
        }
    }
}
