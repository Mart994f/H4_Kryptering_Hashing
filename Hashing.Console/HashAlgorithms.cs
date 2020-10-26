using System.Security.Cryptography;

namespace Hashing.ConsoleApplication
{
    public class HashAlgorithms
    {
        public byte[] ComputeHashSha1(byte[] toBeHashed)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }
        }

        public byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        public byte[] ComputeHashSha384(byte[] toBeHashed)
        {
            using (var md5 = SHA384.Create())
            {
                return md5.ComputeHash(toBeHashed);
            }
        }

        public byte[] ComputeHashSha512(byte[] toBeHashed)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHashed);
            }
        }
    }
}
