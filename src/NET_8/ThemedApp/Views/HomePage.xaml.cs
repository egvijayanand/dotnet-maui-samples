namespace ThemedApp.Views
{
    public partial class HomePage : ContentPage
    {
        private int _themeId;

        private readonly Dictionary<int, ResourceDictionary> _resources = new()
        {
            { 0, new Theme0() },
            { 1, new Theme1() },
            { 2, new Theme2() },
            { 3, new Theme3() },
            { 4, new Theme4() }
        };

        public HomePage()
        {
            InitializeComponent();
            Application.Current!.Resources.MergedDictionaries.Add(_resources[_themeId]);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            Dispatcher.Dispatch(() =>
            {
                Application.Current!.Resources.MergedDictionaries.Remove(_resources[_themeId]);
                _themeId = ((Picker)sender).SelectedIndex;
                Application.Current!.Resources.MergedDictionaries.Add(_resources[_themeId]);
            });
        }
    }
}
