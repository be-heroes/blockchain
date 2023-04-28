using System.ComponentModel.DataAnnotations;
using System.Text;

using BeHeroes.CodeOps.Abstractions.Encryption;

using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

using ProtoBuf;

namespace BeHeroes.Blockchain.Cosmos.Keys
{
    public abstract class PrivateKey : Key
    {
        protected readonly byte[] _keyData = Array.Empty<byte>();

        public override int KeySize => _keyData.Length;

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(KeySize == 0)
                yield return new ValidationResult("Key is not initialized");
        }
    }
}