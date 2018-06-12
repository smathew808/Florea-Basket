using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace CS325_broadSword_flowerProject
{
    internal static class SaltedHashbrowns
    { 
        //function to convert byte arrays to a hex string (for hash function)
        private static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        //Creates a salt to be used when making a password hash
        internal static String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buffer = new byte[size];
            rng.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
        //Generates a hash to be stored in the database with salt
        internal static String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256HashString = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256HashString.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }
    }
}

