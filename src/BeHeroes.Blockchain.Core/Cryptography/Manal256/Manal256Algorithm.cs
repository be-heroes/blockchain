using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Core.Cryptography.Manal256
{
    public sealed class Manal256Algorithm : Algorithm
    {
        public static string Name => "MANAL";

        public Manal256Algorithm() : base(Name, 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, null)
        {

        }
    }
}