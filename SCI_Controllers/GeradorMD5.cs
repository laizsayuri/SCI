using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SCI_Controllers
{
    public static class GeradorMD5
    {
        public static string ToMD5(this string text)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}