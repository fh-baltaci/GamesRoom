using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesRoom.Core.Data;
using GamesRoom.Core.Models;

namespace GamesRoom.Core.Context
{
    public static class CurrentUserAccessor
    {

        private static User _currentUser;

        public static User GetCurrentUser()
        {
            return _currentUser;
        }

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }
    }
}
