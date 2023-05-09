using System.ComponentModel.DataAnnotations;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Strings;

namespace BeHeroes.Blockchain.Core.Cryptography.Manal256
{
    public sealed class Manal256Key : Key
    {
        public static readonly Manal256Key Empty = new Manal256Key(Array.Empty<byte>());

        internal IReadOnlyCollection<byte> RawData => _rawData.AsReadOnly();

        public Manal256Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate: isPrivate)
        {
        }

        //TODO: Return as IBiometricFeature[] once abstraction is in place.
        internal ValueTask<byte[]> ExtracFeatures()
        {
            throw new NotImplementedException();            
        }

        public override string ToString()
        {
            return (!IsPrivate) ? (HexString)_rawData : base.ToString();
        }
        
        //TODO: Implement validation of rawData to ensure headers, etc.        
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }   
}