using System.ComponentModel.DataAnnotations;
using System.Text;

using BeHeroes.CodeOps.Abstractions.Encryption;

using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

using ProtoBuf;

namespace BeHeroes.Blockchain.Cosmos.Keys
{
    [ProtoContract]
    public abstract class PublicKey : Key
    {
        [ProtoMember(1)]
        public override string KeyId {
            get {
                return base.KeyId;
            }
            set{
                base.KeyId = value;
            }
        }

        [ProtoMember(2)]
        public byte[] KeyData
        {
            get; init;
        }
                
        public override int KeySize => KeyData.Length;

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {   
            if(KeyData == null || KeySize == 0)
                yield return new ValidationResult("KeyData is not initialized");

            if(string.IsNullOrEmpty(KeyId))
                yield return new ValidationResult("KeyId is not initialized");

            base.Validate(validationContext);
        }
    }
}