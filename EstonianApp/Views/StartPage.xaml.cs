namespace Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}
    //async void kalastus_Clicked(System.Object sender, System.EventArgs e)
    //        => Application.Current.MainPage = new NavigationPage(new FishingPage());
    //async void fish_Clicked(System.Object sender, System.EventArgs e)
    //    => Application.Current.MainPage = new NavigationPage(new FishSpeciesPage());
    async void water_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new BodyOfWater());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());

}