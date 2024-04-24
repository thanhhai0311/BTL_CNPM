using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using center_management_app.Services.models;

namespace center_management_app.Services.utils
{
    class Helpers
    {
        public static string GenerateUID()
        {
            return Nanoid.Nanoid.Generate(alphabet: "0123456789ABCDEF", size: 10);
        }

        public static int ConvertToInt(object value, int defaultValue = 0)
        {
            try
            {
                return value.GetType() == typeof(DBNull) ? defaultValue : int.Parse(value.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static long ConvertToLong(object value, long defaultValue = 0)
        {
            try
            {
                return value.GetType() == typeof(DBNull) ? defaultValue : long.Parse(value.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static string NormalizeStringValue(string value)
        {
            return value != null ? $"'{value}'" : "null";
        }

        public static string Base64Encode(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            if (string.IsNullOrEmpty(base64EncodedData)) return string.Empty;
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static bool IsBase64(string base64String)
        {
            if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch
            {
            }
            return false;
        }
    }
}
