using TestApp.Models;
using TestApp.Services;
using VijayAnand.MauiToolkit.Services;

namespace TestApp
{
    public partial class App : Application
    {
        private static readonly object locker = new();
        private readonly IThemeService? themeService;

        public App()
        {
            if (Instance == null)
            {
                lock (locker)
                {
                    if (Instance == null)
                    {
                        Instance = this;
                    }
                }
            }

            InitializeComponent();
            MainPage = new AppShell();

            themeService = AppService.GetService<IThemeService>();

            User = new UserModel();
            // Add logic to check whether the user is authenticated or not and then update this flag
            User.Authenticated = false;
        }

        public static App? Instance { get; private set; }

        public UserModel User { get; internal set; }

        protected override void OnStart()
        {
            OnResume();
        }

        protected override void OnResume()
        {
            themeService?.SetTheme();
            RequestedThemeChanged += OnAppThemeChangeRequested;
        }

        protected override void OnSleep()
        {
            RequestedThemeChanged -= OnAppThemeChangeRequested;
        }

        private void OnAppThemeChangeRequested(object? sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() => themeService?.SetTheme());
        }
    }
}
