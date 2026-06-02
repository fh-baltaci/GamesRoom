
using GamesRoom.Core.Data;

namespace GamesRoom.UI.Pages;

public partial class ReservationsPage : ContentPage
{
	public ReservationsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		ReservationsCollectionView.ItemsSource = null;
        ReservationsCollectionView.ItemsSource = FakeDatabase.GetAllReservations();
    }

	private async void OnCreateReservationClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(CreateReservationPage));
	}
}