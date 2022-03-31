namespace TestApp.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        private readonly IPreferences preferences;
        private readonly IThemeService theme;

        public SettingsViewModel(IPreferences preferences, IThemeService theme)
        {
            this.preferences = preferences;
            this.theme = theme;
            Title = "Settings";
        }

        public int Theme
        {
            get => theme?.Theme ?? 0;
            set
            {
                preferences?.Set(nameof(Theme), value, null);
                theme?.SetTheme();
            }
        }

        public bool UseSystem
        {
            get => Theme == 0;
            set
            {
                if (value)
                {
                    Theme = 0;
                }
            }
        }

        public bool LightTheme
        {
            get => Theme == 1;
            set
            {
                if (value)
                {
                    Theme = 1;
                }
            }
        }

        public bool DarkTheme
        {
            get => Theme == 2;
            set
            {
                if (value)
                {
                    Theme = 2;
                }
            }
        }
    }
}
