using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesRoom.Core.Models
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public User User { get; set; }
        public GameSpot GameSpot { get; set; }

        public Reservation(int id, User user, 
            GameSpot gameSpot, DateTime start, DateTime end)
        {
            this.Id = id;
            this.User = user;
            this.GameSpot = gameSpot;
            this.StartTime = start;
            this.EndTime = end;
        }
    }
}
