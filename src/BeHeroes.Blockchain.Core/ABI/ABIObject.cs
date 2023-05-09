using BeHeroes.Blockchain.Core.ABI;

namespace BeHeroes.Domain.Blockchain.ABI
{
    public abstract class ABIObject : IABIObject
    {
        public string Name => ABIType?.ToString() ?? string.Empty;

        public virtual string CanonicalName => Name;

        public byte[] RawData { get; init; }

        public ABIType ABIType { get; init; }

        public int FixedSize { get; init; } = -1;

        protected ABIObject(byte[] data, ABIType abiType)
        {
            RawData = data;

            //TODO: Look at ideas to extract known types from byte arrays so we dont have to implement a standalone converter / mapper, it will be better to encapsulate the type conversion logic internally in the diff sub types.
            ABIType = abiType;

            //TODO: Implement logic to infer from the known type if its fixed size (if not, its assumed to be dynamic == -1)            
        }

        //TODO: Test GetHashCode function for collisions once we have a large number of objects buffered
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = (int)2166136261;

                hash = hash * 16777619 ^ RawData?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ ABIType?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ CanonicalName?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ FixedSize;

                return hash;
            }
        }
    }
}
