using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesRoom.Core.Data;
using GamesRoom.Core.Models;

namespace GamesRoom.Core.Security
{
    public static class AuthService
    {

        public static User? Login(string username, string password)
        {
            User? user = FakeDatabase.Users.First(x => x.Name == username);

            if (user == null)
            {
                return null;
            }

            bool passwordIsValid = VerifyPassword(password, user.PasswordHash);

            return passwordIsValid ? user : null;
        }

        private static bool VerifyPassword(string password, string hash)
        {
            string inputHash = PasswordHasher.HashPassword(password);

            bool result = inputHash == hash;

            return result;
        }
    }
}
