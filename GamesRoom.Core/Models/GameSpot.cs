using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Models
{
    public abstract class GameSpot : IEntity
    {
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public int Id { get ; set; }

        protected GameSpot(int id, string name, int maxPlayers)
        {
            this.Id = id;
            this.Name = name;
            this.MaxPlayers = maxPlayers;
        }
    }
}
