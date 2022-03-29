using TestApp.Services;
using VijayAnand.MauiToolkit.Services;

namespace TestApp
{
    public partial class SettingsPage : ContentPage
    {
        private readonly IPreferences? preferences;
        private readonly IThemeService? theme;

        public SettingsPage()
        {
            InitializeComponent();
            preferences = AppService.GetService<IPreferences>();
            theme = AppService.GetService<IThemeService>();
            BindingContext = this;
        }

        public int Theme
        {
            get => preferences?.Get(nameof(Theme), 0, null) ?? 0;
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
