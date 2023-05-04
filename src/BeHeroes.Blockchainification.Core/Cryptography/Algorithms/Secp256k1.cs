using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Secp256k1 : Algorithm
    {
        private readonly int _keySize;

        private readonly KeySizes[] _legalSizes;

        public Secp256k1()
        {
            _keySize = 256;
            _legalSizes = new KeySizes[]{ new KeySizes(256, 4096, 64)};

            Name = "secp256k1";
        }

        public override int GetKeySize()
        {
            return _keySize;
        }

        public override KeySizes[] GetLegalKeySizes()
        {
            return _legalSizes;
        }
    }
}