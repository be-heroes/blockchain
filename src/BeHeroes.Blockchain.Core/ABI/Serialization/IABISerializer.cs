namespace BeHeroes.Blockchain.Core.ABI.Serialization
{
    //TODO: Finish this interface and provide abstraction for basic fields, props and methods
    public interface IABISerializer
    {
        byte[] Serialize<T>(T obj) where T : IABIObject;

        T Deserialize<T>(byte[] bytes) where T : IABIObject;
    }
}