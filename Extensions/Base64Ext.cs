using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.Extensions
{
    public static class Base64Ext
    {
        public static string ToBase64(this string str)
        {
            byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }


        public static string FromBase64(this string str)
        {
            var bytes = Convert.FromBase64String(str);
            return System.Text.Encoding.Default.GetString(bytes);
        }
    }
}
