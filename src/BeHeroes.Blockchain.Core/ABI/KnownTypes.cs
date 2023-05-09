namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Implement support for remaining ETH ABI types @ https://docs.soliditylang.org/en/develop/types.html
    //TODO: Investigate compatiblity between ETH ABI and Cosmos ABI.
    public enum KnownTypes
    {
        Array,
        Bool,
        Int32,
        UInt32,
        Address,
        String,
        Bytes
    }
}