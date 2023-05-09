namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Finish this interface
    public interface IObject
    {
        string Name { get; }

        string CanonicalName { get; }

        byte[] RawData { get; }

        KnownType ABIType { get; }

        int FixedSize { get; }
    }
}