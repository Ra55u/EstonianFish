using Services;
using EstonianApp.Models;
using System.Numerics;

namespace Views;

public partial class FishingPage : ContentPage
{
    public FishingPage(Fish fish)
    {
        InitializeComponent();

        this.BindingContext = fish;
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}