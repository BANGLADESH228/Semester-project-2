using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SemestreWork
{
    public class Cryptography
    {
        //public static string HashPassword(string password)
        //{
        //    byte[] data = Encoding.ASCII.GetBytes(password);
        //    byte[] result;
        //    SHA512 shaM = new SHA512Managed();
        //    result = shaM.ComputeHash(data);
        //    return Convert.ToBase64String(result);
        //}

        public static string GetHashString(string password)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(password);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

        //public static bool VerifyHashedPassword(string hashedPassword, string password)
        //{
        //    return hashedPassword == (password);
        //}

    }
}
