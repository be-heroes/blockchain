using BeHeroes.CodeOps.Abstractions.Protocols.Http;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Domain.Trading.Exchanges
{
    public interface IExchange : ISignatureProvider, IHttpClient
    {
    }
}
