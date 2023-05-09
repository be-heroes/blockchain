using BeHeroes.Blockchain.Core.ABI.Serialization;

namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Finish this implementation
    public sealed class ABIType : IABIType
    {
        public KnownTypes TypeIndicator { get; init; }

        public ABIType(KnownTypes typeIndicator)
        {
            TypeIndicator = typeIndicator;
        }
    }
}