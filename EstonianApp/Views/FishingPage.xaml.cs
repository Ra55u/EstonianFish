using Services;
using EstonianApp.Models;
using System.Numerics;

namespace Views;

public partial class FishingPage : ContentPage
{
    public FishingPage()
    {
        InitializeComponent();
    }
    //async void water_clicked(System.Object sender, System.EventArgs e)
    //    => Application.Current.MainPage = new NavigationPage(new BodyOfWater());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());
}