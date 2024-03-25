using EstonianApp.Models;

namespace EstonianApp.Views;

public partial class WaterDetailsPage : ContentPage
{
    public WaterDetailsPage(Water water)
    {
        InitializeComponent();

        this.BindingContext = water;
    }

	async void BackButton_Clicked(object sender, EventArgs e)
	{
        await Navigation.PopAsync();
	}
}