using MTA.ViewModels;

namespace MTA.Pages;

public partial class MoodDetailsPage : ContentPage
{
    public MoodDetailsPage()
    {
        InitializeComponent();
        BindingContext = new MoodDetailsViewModel();
    }
}
