namespace Views;

public partial class FishingPage : ContentPage
{
	public FishingPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}