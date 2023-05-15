using BeHeroes.CodeOps.Abstractions.Protocols.Http;
using BeHeroes.Infrastructure.Exchanges.Bitfinex.Http.Headers;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex.Http
{
    public sealed class BitfinexHttpClient : HttpClient, IHttpClient
    {
        IEnumerable<IHttpHeader> IHttpClient.DefaultRequestHeaders => DefaultRequestHeaders.Select(header => new BitfinexHeader(header.Key, header.Value));

        public BitfinexHttpClient(string apiKey, string apiSignature, string apiPayload) : base()
        {
            var apiKeyHeader = new BitfinexApiKeyHeader(new string[]{apiKey});
            var apiSignatureHeader = new BitfinexApiSignatureHeader(new string[]{apiSignature});
            var apiPayloadHeader = new BitfinexApiPayloadHeader(new string[]{apiPayload});

            DefaultRequestHeaders.Add(apiKeyHeader.Name, apiKeyHeader.Values);
            DefaultRequestHeaders.Add(apiSignatureHeader.Name, apiSignatureHeader.Values);
            DefaultRequestHeaders.Add(apiPayloadHeader.Name, apiPayloadHeader.Values);
        }

        public ValueTask DisposeAsync()
        {
            Dispose();

            return ValueTask.CompletedTask;
        }
    }
}

