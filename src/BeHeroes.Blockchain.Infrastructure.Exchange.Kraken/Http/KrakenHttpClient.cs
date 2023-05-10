using BeHeroes.CodeOps.Abstractions.Protocols.Http;
using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Headers;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http
{
    public sealed class KrakenHttpClient : HttpClient, IHttpClient
    {
        IEnumerable<IHttpHeader> IHttpClient.DefaultRequestHeaders => DefaultRequestHeaders.Select(header => new KrakenHeader(header.Key, header.Value));

        public KrakenHttpClient(string apiKey, string apiSecret) : base()
        {
            var apiKeyHeader = new KrakenApiKeyHeader(new string[]{apiKey});
            var apiSignatureHeader = new KrakenApiSignatureHeader(new string[]{apiSecret});

            DefaultRequestHeaders.Add(apiKeyHeader.Name, apiKeyHeader.Values);
            DefaultRequestHeaders.Add(apiSignatureHeader.Name, apiSignatureHeader.Values);
        }

        public ValueTask DisposeAsync()
        {
            Dispose();

            return ValueTask.CompletedTask;
        }
    }
}

