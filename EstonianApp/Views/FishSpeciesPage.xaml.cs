using EstonianApp.Models;
using System.Windows.Input;
namespace EstonianApp.Views;

public partial class FishSpeciesPage : ContentPage
{
    public ICommand SearchCommand { get; }
    public FishSpeciesPage()
    {
        InitializeComponent();
        searchBar.SearchCommand = new Command<string>(async (searchQuery) =>
        {
            var searchResults = Services.FishService.SearchAndSortFish(searchQuery);
            await Navigation.PushAsync(new FishSearchResultsPage(searchResults));
        });
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
        await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
    }
}