namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Http.Headers
{
    public sealed record class BitfinexApiSignatureHeader : BitfinexHeader
    {
        public const string HeaderName = "X-BFX-SIGNATURE";

        public BitfinexApiSignatureHeader(string value) : base(HeaderName, value)
        {

        }

        public BitfinexApiSignatureHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}