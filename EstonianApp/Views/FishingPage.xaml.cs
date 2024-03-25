using EstonianApp.Models;
using System.Numerics;
using Views;


namespace EstonianApp.Views;

public partial class FishingPage : ContentPage
{
    public FishingPage()
    {
        InitializeComponent();
    }
    async void fishing_Clicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new FishingPage());
    async void fish_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new FishSpeciesPage());
    async void water_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new WaterTypePage());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());
}