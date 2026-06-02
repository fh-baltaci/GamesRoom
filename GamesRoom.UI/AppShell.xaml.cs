using GamesRoom.UI.Pages;

namespace GamesRoom.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ReservationsPage), typeof(ReservationsPage));
            Routing.RegisterRoute(nameof(CreateReservationPage), typeof(CreateReservationPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
