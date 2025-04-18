using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace MTA.ViewModels;

[QueryProperty(nameof(MoodName), "moodName")]
public partial class MoodDetailsViewModel : ObservableObject
{
    [ObservableProperty]
    private string moodName;
}
