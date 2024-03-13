using EstonianApp.Models;

namespace EstonianApp.Views
{
    public partial class FishSearchResultsPage : ContentPage
    {
        public List<Fish> searchResults { get; set; }

        public FishSearchResultsPage(List<Fish> searchResults)
        {
            InitializeComponent();
            this.searchResults = searchResults; // Set the searchResults property
            this.BindingContext = this; // Set the BindingContext to the page itself
        }

        async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FishSpeciesPage());
        }
        async void Fish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
        }
    }
}
