using EstonianApp.Models;
using EstonianApp.Services;

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
}