using System.Security.Cryptography;

namespace BeHeroes.Blockchain.Core.Cryptography.Utils
{
    public static class Helper
    {
        /// <summary>
        /// Creates a cryptographically secure random key string.
        /// </summary>
        /// <param name="count">The number of bytes of random values to create the string from</param>
        /// <returns>A secure random string</returns>
        public static string CreateSecureRandomString(int count = 32) => Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
    }
}