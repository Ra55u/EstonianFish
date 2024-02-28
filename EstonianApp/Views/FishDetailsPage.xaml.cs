using EstonianApp.Models;

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