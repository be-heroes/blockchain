namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Finish this interface
    public interface IABIObject
    {
        string Name { get; }

        string CanonicalName { get; }

        byte[] RawData { get; }

        ABIType ABIType { get; }

        int FixedSize { get; }
    }
}