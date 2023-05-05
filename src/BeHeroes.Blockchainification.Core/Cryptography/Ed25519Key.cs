using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Ed25519Key : Key
    {
        private readonly int _keySize;

        public override int KeySize 
        { 
            get
            {
                return _keySize;
            } 
        }

        public Ed25519Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate)
        {
            _keySize = 256;
        }
    }   
}