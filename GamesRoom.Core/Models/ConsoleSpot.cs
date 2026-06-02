using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Models
{
    public class ConsoleSpot : GameSpot
    {
        public string ConsoleType { get; set; }

        public ConsoleSpot(int id, string name, int maxPlayers, string consoleType)
            : base(id, name, maxPlayers)
        {
            this.ConsoleType = consoleType;
        }
    }
}
