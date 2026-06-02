using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GamesRoom.Core.Models;
using GamesRoom.Core.Security;

namespace GamesRoom.Core.Data
{
    public static class FakeDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<GameSpot> GameSpots { get; set; } = new List<GameSpot>();
        public static List<Reservation> Reservations { get; set; } = new List<Reservation>();

        static FakeDatabase()
        {
            Users.Add(new User(1, "Jan Novák", "honzaGamer123", PasswordHasher.HashPassword("Admin123")));
            Users.Add(new User(2, "Petr Klíč", "petrkey123", PasswordHasher.HashPassword("Admin123")));
            Users.Add(new User(3, "Josef Novák", "jozkagamer", PasswordHasher.HashPassword("Admin123")));

            GameSpots.Add(new ConsoleSpot(1, "XBOX #1", 2, "XBOX"));
            GameSpots.Add(new ConsoleSpot(2, "XBOX #2", 2, "XBOX"));
            GameSpots.Add(new PcSpot(3, "PC #1", 2, true));

            Reservations.Add(new Reservation(1, Users[0], GameSpots[0], DateTime.Now.AddDays(-1), DateTime.Now.AddHours(1)));
            Reservations.Add(new Reservation(2, Users[1], GameSpots[1], DateTime.Now.AddDays(-2), DateTime.Now.AddHours(1)));
            Reservations.Add(new Reservation(3, Users[2], GameSpots[2], DateTime.Now.AddDays(-3), DateTime.Now.AddHours(1)));

        }

        public static List<Reservation> GetAllReservations()
        {
            return Reservations;
        }

        public static List<GameSpot> GetAllGameSpots()
        {
            return GameSpots;
        }
              
        public static void AddReservation(int userId, 
            GameSpot gameSpot, DateTime startTime, DateTime endTime)
        {
            var user = Users.Where(user => user.Id == userId).First(); // LINQ

            if (user is null) throw new Exception("User not found");

            int reservationId = Reservations.Count + 1;
            var reservation = new Reservation(reservationId, user, gameSpot, startTime, endTime);

            Reservations.Add(reservation);
        }
    }
}
