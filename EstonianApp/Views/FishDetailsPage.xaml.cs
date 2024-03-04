using EstonianApp.Models;
using System.Numerics;

namespace EstonianApp.Views;

public partial class FishDetailsPage : ContentPage
{
    public FishDetailsPage(Fish fish)
    {
        InitializeComponent();
        this.BindingContext = fish;

    }

	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}