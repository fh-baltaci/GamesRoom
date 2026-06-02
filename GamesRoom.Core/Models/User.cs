using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Models
{
    public class User : IEntity
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Id { get; set; }

        public User(int id, string name, string nickname)
        {
            this.Id = id;
            this.Name = name;
            this.Nickname = nickname;
        }
    }
}
