using GamesRoom.Core.Security;

namespace GamesRoom.UI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	public async void OnLoginClicked(object sender, EventArgs e)
	{
		string username = UserNameEntry.Text;
		string password = PasswordEntry.Text;

		if (username == null || password == null)
		{
			await DisplayAlert("Chyba", "Chybí jméno nebo heslo", "OK");
			return;
		}

		var user = AuthService.Login(username, password);

		if (user == null)
		{
			await DisplayAlert("Chyba", "Neplatné jméno nebo heslo", "OK");
			return;
		}

		Application.Current!.MainPage = new AppShell();
	}
}