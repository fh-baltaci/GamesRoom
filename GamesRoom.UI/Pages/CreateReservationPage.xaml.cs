using GamesRoom.Core.Context;
using GamesRoom.Core.Data;
using GamesRoom.Core.Models;

namespace GamesRoom.UI.Pages;

public partial class CreateReservationPage : ContentPage
{
	public CreateReservationPage()
	{
		InitializeComponent();

		GameSpotPicker.ItemsSource = FakeDatabase.GetAllGameSpots();
		ReservationDatePicker.Date = DateTime.Today;
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}

	private async void OnSaveClicked(object sender, EventArgs e)
	{
		GameSpot? selectedGameSpot = GameSpotPicker.SelectedItem as GameSpot;

		if (selectedGameSpot == null)
		{
			await DisplayAlert("Chyba", "Vyber herní místo", "Ok");
		}

		DateTime selectedDate = ReservationDatePicker.Date;

		DateTime startTime = selectedDate.Date + StartTimePicker.Time;
		DateTime endTime = selectedDate.Date + EndTimePicker.Time;

		var currentUser = CurrentUserAccessor.GetCurrentUser();

		FakeDatabase.AddReservation(
			currentUser.Id, 
			selectedGameSpot, 
			startTime, 
			endTime);

		await DisplayAlert("Hotovo", "Rezervace byla vytvoøena", "Ok");

		await Shell.Current.GoToAsync(nameof(ReservationsPage));
	}
}