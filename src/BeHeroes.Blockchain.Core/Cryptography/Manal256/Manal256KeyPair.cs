using BeHeroes.CodeOps.Abstractions.Cryptography;

using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace BeHeroes.Blockchain.Core.Cryptography.Manal256
{
    public sealed class Manal256KeyPair : KeyPair
    {
        public Manal256KeyPair() : this(new Manal256Algorithm())
        {        

        }
        
        public Manal256KeyPair(Manal256Algorithm algorithm) : this(algorithm, Manal256Key.Empty, Manal256Key.Empty)
        {            
            throw new NotImplementedException();
        }
        
        public Manal256KeyPair(Manal256Algorithm algorithm, Manal256Key privateKey, Manal256Key publicKey) : base(algorithm, privateKey, publicKey)
        {
        }
    }
}