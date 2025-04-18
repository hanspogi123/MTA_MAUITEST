namespace MTA.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    
    private async void LightMode(object sender, EventArgs e)
    {
        await this.FadeTo(0, 250, Easing.CubicInOut);
        Application.Current.Resources["bgColor"] = Colors.White;
        Application.Current.Resources["fgColor"] = Colors.Black;
        await this.FadeTo(1, 250, Easing.CubicInOut);
    }

    private async void DarkMode(object sender, EventArgs e)
    {
        await this.FadeTo(0, 250, Easing.CubicInOut);
        Application.Current.Resources["bgColor"] = Colors.Black;
        Application.Current.Resources["fgColor"] = Colors.White;
        await this.FadeTo(1, 250, Easing.CubicInOut);
    }

    private async void OnViewMoodClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("mooddetails?mood=Happy");
    }

}
