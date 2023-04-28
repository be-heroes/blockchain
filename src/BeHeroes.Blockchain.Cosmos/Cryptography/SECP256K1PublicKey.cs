namespace BeHeroes.Blockchain.Cosmos.Keys
{
    public sealed class SECP256K1PublicKey : PublicKey
    {
        public SECP256K1PublicKey()
        {
            KeyId = "/cosmos.crypto.secp256k1.PubKey";
        }    
    }
}