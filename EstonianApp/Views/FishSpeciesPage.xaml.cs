using EstonianApp.Models;
using EstonianApp.Services;
using System.Numerics;

namespace EstonianApp.Views;

public partial class FishSpeciesPage : ContentPage
{
    public FishSpeciesPage()
    {
        InitializeComponent();

        lstPopularFishSpecies.ItemsSource = Services.FishService.GetFeaturedFish();
        lstAllFishSpecies.ItemsSource = Services.FishService.GetAllFish();
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }
    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1);
        await MainContentGrid.ScaleTo(0.8);
        _ = MainContentGrid.FadeTo(0.8);
    }

    async void Fish_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}