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
        public static User GetCurrentUser()
        {
            return FakeDatabase.Users.First();
        }
    }
}
