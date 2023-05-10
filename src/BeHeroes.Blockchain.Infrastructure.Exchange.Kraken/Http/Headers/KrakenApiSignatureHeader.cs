namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Headers
{
    public sealed record class KrakenApiSignatureHeader : KrakenHeader
    {
        public const string HeaderName = "API-Sign";

        public KrakenApiSignatureHeader(string value) : base(HeaderName, value)
        {

        }

        public KrakenApiSignatureHeader(IEnumerable<string> values) : base(HeaderName, values)
        {

        }
    }
}