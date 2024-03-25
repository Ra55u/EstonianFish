using EstonianApp.Models;
using EstonianApp.Views;

namespace Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
        lstPopularFishSpecies.ItemsSource = EstonianApp.Services.FishService.GetFeaturedFish();
        lstPopularWaterType.ItemsSource = EstonianApp.Services.WaterService.GetFeaturedWater();

    }
    async void Fish_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
    }
    async void Water_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new WaterDetailsPage(e.CurrentSelection.First() as Water));
    }
    async void kalastus_Clicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new FishingPage());
    async void fish_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new FishSpeciesPage());
    async void water_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new WaterTypePage());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());

}