using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace AutoStonks.API
{
    public class PasswordHashing
    {
        private const int saltSize = 32;
        private const int hashSize = 32;
        private const int iterationsCount = 10000;
        public PasswordHashing()
        {
        }

        public byte[] GetSalt()
        {
            byte[] salt = new byte[saltSize];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt);
            }
            return salt;
        }
        public byte[] GetKey(string password, byte[] salt)
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, salt, iterationsCount);
            return rfc2898.GetBytes(hashSize);
        }
        public bool IsValid(string password, string saltValue, string keyValue)
        {
            byte[] salt = Encoding.Unicode.GetBytes(saltValue);
            byte[] hashedValue = GetKey(password, salt);
            if (Encoding.Unicode.GetString(hashedValue) == keyValue) return true;
            else return false;
        }
    }
}
