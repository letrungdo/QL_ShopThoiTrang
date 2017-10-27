using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class PasswordEncrypt
    {
        public const string PUBLIC_KEY = "LeTrungDo";
        /// <summary>
        /// Encrypts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public string Encrypt(string value, string publickKey)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            byte[] bytesIn = Encoding.UTF8.GetBytes(value);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(publickKey);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateEncryptor();
            CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt,
            CryptoStreamMode.Write);
            cryptStreem.Write(bytesIn, 0, bytesIn.Length);
            cryptStreem.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();
            cryptStreem.Close();
            msOut.Close();
            return Convert.ToBase64String(bytesOut);
        }
    }
}
