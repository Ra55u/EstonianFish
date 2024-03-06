using EstonianApp.Models;
using System.Windows.Input;
using Views;

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
    async void Fish_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
    }
    //async void kalastus_Clicked(System.Object sender, System.EventArgs e)
    //        => Application.Current.MainPage = new NavigationPage(new FishingPage());
    async void fish_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new FishSpeciesPage());
    //async void water_clicked(System.Object sender, System.EventArgs e)
    //    => Application.Current.MainPage = new NavigationPage(new BodyOfWater());
    async void home_clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new StartPage());
}