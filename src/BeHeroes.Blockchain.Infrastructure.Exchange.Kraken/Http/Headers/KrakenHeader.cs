using BeHeroes.CodeOps.Abstractions.Protocols.Http;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Headers
{
    public record class KrakenHeader : HttpHeader
    {
        public KrakenHeader(string name, string value) : this(name, new string[]{ value })
        {

        }

        public KrakenHeader(string name, IEnumerable<string> values) : base(name, values)
        {

        }
    }
}