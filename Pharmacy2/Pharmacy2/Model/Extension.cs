using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pharmacy2.Model
{
    public static class Extension
    {
        public static string HashPassword(string pass)
        {
            byte[] byteArrays = Encoding.UTF8.GetBytes(pass);
            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArrays);
            string hashedPassword = Encoding.UTF8.GetString(hashedArray);

            return hashedPassword;
        }

        public static bool CheckPassword(string pass,string hashedPassword)
        {
            return HashPassword(pass) == hashedPassword;
        }
    }
}
