using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Security
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();

            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes);
        }

    }
}
