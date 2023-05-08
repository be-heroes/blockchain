namespace BeHeroes.Blockchain.Core.Cryptography
{
    public sealed class CryptographyException : Exception
    {
        public CryptographyException()
        { }

        public CryptographyException(string message)
            : base(message)
        { }

        public CryptographyException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}