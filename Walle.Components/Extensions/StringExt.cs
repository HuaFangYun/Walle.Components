using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Walle.Components.Extensions
{
    public static class StringExt
    {
        public static string GetMD5Hash(this string text)
        {
            byte[] data = Encoding.Unicode.GetBytes(text);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(data);
            string t = "";
            for (int i = 0; i < result.Length; i++)
            {
                t += Convert.ToString(result[i], 16);
            }
            return t;
        }
    }
}
