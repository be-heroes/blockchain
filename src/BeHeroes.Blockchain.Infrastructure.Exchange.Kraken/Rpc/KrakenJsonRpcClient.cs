//TODO: Replace with typed HttpClient
// using BeHeroes.Core.Common.Rpc;
// using BeHeroes.Core.Interfaces.Rpc;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Response;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc
// {
//     public sealed class KrakenJsonRpcClient : JsonRpcClient<KrakenRpcRequest, KrakenRpcResponse>
//     {
//         public KrakenJsonRpcClient() : base(new JsonRpcResponseFormatter<KrakenRpcResponse>())
//         {
//             // Can only be used for public requests
//         }

//         public KrakenJsonRpcClient(string apiKey, string apiSecret) : base(new JsonRpcResponseFormatter<KrakenRpcResponse>())
//         {
//             ApiKey = apiKey;
//             ApiKeyHeaderName = KrakenCustomHeaders.ApiKey;
//             ApiSecret = apiSecret;
//             ApiSecretHeaderName = KrakenCustomHeaders.ApiSign;
//         }

//     }
// }
