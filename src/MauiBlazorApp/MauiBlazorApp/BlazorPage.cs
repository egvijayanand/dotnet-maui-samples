using RazorLib;

namespace MauiBlazorApp
{
    public partial class BlazorPage : ContentPage, IDisposable
    {
        private readonly AppState _state;

        public BlazorPage(AppState appState)
        {
            InitializeComponent();
            _state = appState;
            _state.OnChanged += OnStateChanged;
        }

        private void OnStateChanged()
        {
            lblCounter.Text = $"The current count is: {_state.CurrentCount}";
        }

        private void Counter_Clicked(object? sender, EventArgs e)
        {
            _state.IncrementCount();
        }

        public void Dispose()
        {
            _state.OnChanged -= OnStateChanged;
        }
    }
}
