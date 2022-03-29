namespace TestApp.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IPreferences preferences;

        public ThemeService(IPreferences preferences)
        {
            this.preferences = preferences;
        }

        public int Theme
        {
            get => preferences.Get(nameof(Theme), 0, null);
            set => preferences.Set(nameof(Theme), value, null);
        }

        public void SetTheme()
        {
            Application.Current!.UserAppTheme = Theme switch
            {
                1 => AppTheme.Light,
                2 => AppTheme.Dark,
                _ => AppTheme.Unspecified,
            };
        }
    }
}
