using BeHeroes.CodeOps.Abstractions.Protocols.Http;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Domain.Trading.Interfaces
{
    public interface IExchange : ISignatureProvider, IHttpClient
    {
    }
}
