using System.Globalization;
using System.Numerics;
using BeHeroes.Blockchain.Core.ABI.Serialization;
using BeHeroes.CodeOps.Abstractions.Strings;
using BeHeroes.Domain.Blockchain.ABI;

namespace BeHeroes.Blockchain.Core.ABI.Ethereum
{
    public class Integer : ABIObject
    {
        public override string CanonicalName
        {
            get
            {
                switch (ABIType.TypeIndicator)
                {
                    case KnownTypes.Int32:
                        return "int256";
                    case KnownTypes.UInt32:
                        return "uint256";
                    default:
                        return base.CanonicalName;
                }
            }
        }

        public Integer() : base(Array.Empty<byte>(), new ABIType(KnownTypes.Int32))
        {
        }

        public static implicit operator BigInteger(Integer input)
        {
            return new BigInteger(input.RawData);
        }

        public static implicit operator Integer(BigInteger input)
        {
            return input.ToByteArray();
        }

        public static implicit operator byte[] (Integer input)
        {
            return input.RawData;
        }

        public static implicit operator Integer (byte[] input)
        {
            return new Integer {RawData = input};
        }

        public static implicit operator int (Integer input)
        {
            return (int)(BigInteger)input;
        }

        public static implicit operator Integer(int input)
        {
            return (BigInteger)input;
        }

        public static implicit operator uint(Integer input)
        {
            return (uint)(BigInteger)input;
        }

        public static implicit operator Integer(uint input)
        {
            return (BigInteger)input;
        }

        public static implicit operator long(Integer input)
        {
            return (long)(BigInteger)input;
        }

        public static implicit operator Integer(long input)
        {
            return (BigInteger)input;
        }

        public static implicit operator ulong(Integer input)
        {
            return (ulong)(BigInteger)input;
        }

        public static implicit operator Integer(ulong input)
        {
            return (BigInteger)input;
        }

        public static implicit operator bool(Integer input)
        {
            return Convert.ToBoolean((int)input);
        }

        public static implicit operator Integer(bool input)
        {
            return Convert.ToInt32(input);
        }

        public static implicit operator HexString (Integer input)
        {
            return input.RawData;
        }

        public static implicit operator Integer(HexString input)
        {
            var bytes = BigInteger.Parse(input, NumberStyles.HexNumber).ToByteArray();

            return BitConverter.IsLittleEndian != input.IsLittleEndian ? bytes.Reverse().ToArray() : bytes;
        }
    }
}
