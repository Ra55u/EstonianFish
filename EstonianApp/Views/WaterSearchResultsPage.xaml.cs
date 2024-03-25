using EstonianApp.Models;

namespace EstonianApp.Views
{
    public partial class WaterSearchResultsPage : ContentPage
    {
        public List<Water> searchResults { get; set; }

        public WaterSearchResultsPage(List<Water> searchResults)
        {
            InitializeComponent();
            this.searchResults = searchResults; // Set the searchResults property
            this.BindingContext = this; // Set the BindingContext to the page itself
        }

        async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterTypePage());
        }
        async void Water_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new WaterDetailsPage(e.CurrentSelection.First() as Water));
        }
    }
}
