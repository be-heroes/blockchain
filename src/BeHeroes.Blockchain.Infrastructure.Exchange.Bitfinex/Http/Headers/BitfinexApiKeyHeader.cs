namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Http.Headers
{
    public sealed record class BitfinexApiKeyHeader : BitfinexHeader
    {
        public const string HeaderName = "X-BFX-APIKEY";

        public BitfinexApiKeyHeader(string value) : base(HeaderName, value)
        {

        }

        public BitfinexApiKeyHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}