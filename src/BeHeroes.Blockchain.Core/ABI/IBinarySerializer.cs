namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Finish this interface and provide abstraction for basic fields, props and methods
    public interface IABIBinarySerializer
    {
        byte[] Serialize<T>(T obj) where T : IObject;

        T Deserialize<T>(byte[] bytes) where T : IObject;
    }
}