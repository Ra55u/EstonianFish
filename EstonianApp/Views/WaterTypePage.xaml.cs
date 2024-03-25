using EstonianApp.Models;
using System.Windows.Input;
using Views;

namespace EstonianApp.Views;

public partial class WaterTypePage : ContentPage
{
    public ICommand SearchCommand { get; }
    public WaterTypePage()
    {
        InitializeComponent();
        searchBar.SearchCommand = new Command<string>(async (searchQuery) =>
        {
            var searchResults = Services.WaterService.SearchAndSortWater(searchQuery);
            await Navigation.PushAsync(new WaterSearchResultsPage(searchResults));
        });
        lstPopularWaterType.ItemsSource = Services.WaterService.GetFeaturedWater();
        lstAllWaterType.ItemsSource = Services.WaterService.GetAllWater();
    }
    async void Water_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new WaterDetailsPage(e.CurrentSelection.First() as Water));
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