using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace DataAccessLibrary
{
    enum Atributes
    {
        test
    }
    public enum BooksAtributes
    {
        BookTitle,
        BookEdition,
        BookPrice,
        ModuleCode,
        BooksInstitute,
        LocationID
    }

    public static class Utilities
    {
        private static string IV = "1q8myj6c9s23rgvq"; //16 chars
        private static string key = "b365ghyxa741258dfpol934ecvrg70qs"; //32 chars

        //Check if generic list contains an item
        public static bool CheckIfContains<T>(List<T> _list,T _item) where T:TestInterface
        {
            foreach (var item in _list)
            {
                if (item.isEqualTo(_item))
                {
                    return true;
                }
            }

            return false;
        }
        public static string ExcryptPassword(string _input)
        {
            Byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(_input);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.Key = ASCIIEncoding.ASCII.GetBytes(key);
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;

                var incrypt = endec.CreateEncryptor(endec.Key,endec.IV);

                byte[] enc = incrypt.TransformFinalBlock(textbytes,0,textbytes.Length);
                incrypt.Dispose();

                return Convert.ToBase64String(enc);
            }
        }
        public static string DecryptPassword(string _input)
        {
            Byte[] textbytes = Convert.FromBase64String(_input);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.Key = ASCIIEncoding.ASCII.GetBytes(key);
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;

                var decrypt = endec.CreateDecryptor(endec.Key, endec.IV);

                byte[] enc = decrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                decrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(enc);
            }
        }
    }

    public interface TestInterface
    {
        bool isEqualTo(object _item);
    }
}
