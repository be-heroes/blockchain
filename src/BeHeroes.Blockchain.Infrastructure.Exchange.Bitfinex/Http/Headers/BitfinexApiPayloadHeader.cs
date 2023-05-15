namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Http.Headers
{
    public sealed record class BitfinexApiPayloadHeader : BitfinexHeader
    {
        public const string HeaderName = "X-BFX-PAYLOAD";

        public BitfinexApiPayloadHeader(string value) : base(HeaderName, value)
        {

        }

        public BitfinexApiPayloadHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}