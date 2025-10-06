namespace UnifiedStartup.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count;

        public MainPage() => InitializeComponent();

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            counterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(counterLabel.Text);
        }
    }
}
