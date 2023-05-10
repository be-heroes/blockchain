namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Headers
{
    public sealed record class KrakenApiNonceHeader : KrakenHeader
    {
        public const string HeaderName = "nonce";

        public KrakenApiNonceHeader(string value) : base(HeaderName, value)
        {

        }

        public KrakenApiNonceHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}