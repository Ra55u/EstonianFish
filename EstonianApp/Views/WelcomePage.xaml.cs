namespace Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}
    async void home_clicked(System.Object sender, System.EventArgs e)
    => Application.Current.MainPage = new NavigationPage(new StartPage());
}