using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    internal class RandomCredentialsGenerator
    {
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateRandomString(int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomLogin()
        {
            int loginLength = 8;
            return GenerateRandomString(loginLength);
        }

        public static string GenerateRandomPassword()
        {
            int passwordLength = 10;
            return GenerateRandomString(passwordLength);
        }
    }
}
