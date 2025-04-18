namespace MTA
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("mooddetails", typeof(MTA.Pages.MoodDetailsPage));
            Routing.RegisterRoute("mooddetails", typeof(MTA.Pages.MoodDetailsPage));
        }
    }
}
