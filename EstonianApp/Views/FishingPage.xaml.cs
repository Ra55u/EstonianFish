using EstonianApp.Models;
using System.Numerics;

namespace Views;

public partial class FishingPage : ContentPage
{
    public FishingPage()
    {
        InitializeComponent();
    }
    async void fishing_Clicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new FishingPage());
    async void fish_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new FishingPage());
    async void water_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());
}