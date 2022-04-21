namespace DateCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void Settings_Clicked(object sender, EventArgs e)
            => await GoToAsync("//settings");
    }
}
