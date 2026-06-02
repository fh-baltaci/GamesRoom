using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Models
{
    public class PcSpot : GameSpot
    {
        public bool HasHeadset { get; set; }

        public PcSpot(int id, string name, int maxPlayers, bool hasHeadset)
            : base (id, name, maxPlayers)
        {
            this.HasHeadset = hasHeadset;
        }
    }
}
