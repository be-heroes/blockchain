namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Headers
{
    public sealed record class KrakenApiKeyHeader : KrakenHeader
    {
        public const string HeaderName = "API-Key";

        public KrakenApiKeyHeader(string value) : base(HeaderName, value)
        {

        }

        public KrakenApiKeyHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}