namespace MenuApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnQuitClicked(object? sender, EventArgs e)
        {
            if (await DisplayAlert("Quit", "Are you sure?", "Yes", "No"))
            {
                Application.Current?.Quit();
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
