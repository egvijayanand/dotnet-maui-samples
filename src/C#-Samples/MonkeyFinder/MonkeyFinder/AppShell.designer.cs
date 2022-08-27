namespace MonkeyFinder
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled;
            Resources.Add("BaseStyle", new Style(typeof(Element))
            {
                Setters =
                {
                    new() { Property = Shell.BackgroundColorProperty, Value = AppResource<Color>("Primary") },
                    new() { Property = Shell.ForegroundColorProperty, Value = DeviceInfo.Platform.ToString() switch { nameof(DevicePlatform.WinUI) => AppResource<Color>("Primary"), _ => White } },
                    new() { Property = Shell.TitleColorProperty, Value = White },
                    new() { Property = Shell.DisabledColorProperty, Value = Color.FromArgb("#B4FFFFFF") },
                    new() { Property = Shell.UnselectedColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => Color.FromArgb("#95FFFFFF"), AppTheme.Light or _ => Color.FromArgb("#95000000") } },
                    new() { Property = Shell.TabBarBackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("DarkBackground"), AppTheme.Light or _ => AppResource<Color>("LightBackground") } },
                    new() { Property = Shell.TabBarForegroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("LightBackground"), AppTheme.Light or _ => AppResource<Color>("DarkBackground") } },
                    new() { Property = Shell.TabBarUnselectedColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => Color.FromArgb("#95FFFFFF"), AppTheme.Light or _ => Color.FromArgb("#95000000") } },
                    new() { Property = Shell.TabBarTitleColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("LightBackground"), AppTheme.Light or _ => AppResource<Color>("DarkBackground") } },
                },
            });
            Resources.Add(new Style(typeof(ShellItem))
            {
                BasedOn = (Style)Resources["BaseStyle"],
                ApplyToDerivedTypes = true,
            });
            Items.Add(new ShellContent()
            {
                Title = "Monkeys",
                ContentTemplate = new DataTemplate(typeof(MainPage)),
                Route = "MainPage",
            });
        }
    }
}

