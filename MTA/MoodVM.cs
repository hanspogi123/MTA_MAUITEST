using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MTA.MoodVM;
    public partial class MoodVM:ObservableObject
    {
    [ObservableProperty]
        private string currentMood;

    [ObservableProperty]
    private string moodEmoji;

    public MoodVM()
    {
        currentMood = "No Mood selected";
        moodEmoji = "";
    }

    [RelayCommand]
    private void SetMood(string mood)
    {
        CurrentMood = $"You are feeling {mood}!";
        MoodEmoji = mood switch
        {
            "Happy" => "😊",
            "Sad" => "😢",
            "Angry" => "😡",
            _ => "❓"
        };
    }

    [RelayCommand]
    private void ClearMood()
    {
        MoodEmoji = "";
        CurrentMood = "No Mood Selected";
    }

    [RelayCommand]
    async Task ShowMoodDetails()
    {
        await Shell.Current.GoToAsync($"mooddetails?moodName={CurrentMood}");
    }
}
