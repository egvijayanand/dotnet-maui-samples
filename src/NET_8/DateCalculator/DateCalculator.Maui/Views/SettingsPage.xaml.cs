namespace DateCalculator.Views
{
    public partial class SettingsPage : MauiPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//home");
        }
    }
}
