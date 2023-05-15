using BeHeroes.CodeOps.Abstractions.Protocols.Http;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Http.Headers
{
    public record class BitfinexHeader : HttpHeader
    {
        public BitfinexHeader(string name, string value) : this(name, new string[]{ value })
        {

        }

        public BitfinexHeader(string name, IEnumerable<string> values) : base(name, values)
        {

        }
    }
}