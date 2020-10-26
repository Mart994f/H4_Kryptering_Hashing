using System.Security.Cryptography;

namespace Hashing.ConsoleApplication
{
    class HmacAlgorithms
    {
        #region Private Fields

        private HMAC _hmac;

        #endregion

        #region Constructors

        public HmacAlgorithms(string name)
        {
            if (name.CompareTo("SHA1") == 0)
                _hmac = new HMACSHA1();
            if (name.CompareTo("SHA256") == 0)
                _hmac = new HMACSHA256();
            if (name.CompareTo("SHA384") == 0)
                _hmac = new HMACSHA384();
            if (name.CompareTo("SHA512") == 0)
                _hmac = new HMACSHA512();
        }

        #endregion

        #region Public Method

        public byte[] ComputeMAC(byte[] message, byte[] key)
        {
            _hmac.Key = key;
            return _hmac.ComputeHash(message);
        }

        public bool ValidateAuthenticity(byte[] message, byte[] mac, byte[] key)
        {
            _hmac.Key = key;

            if (CompareByteArray(_hmac.ComputeHash(message), mac, MACByteLength()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Private Helper Methods

        private int MACByteLength()
        {
            return _hmac.HashSize / 8;
        }

        private bool CompareByteArray(byte[] a, byte[] b, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
