namespace Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }
    async void Veekogud_Clicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new BodyOfWater());


}