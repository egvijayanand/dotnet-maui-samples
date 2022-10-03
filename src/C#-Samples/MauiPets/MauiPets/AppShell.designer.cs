namespace MAUIPETS
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            FlyoutBackgroundColor = Color.FromArgb("#9999FF");
            FlyoutBehavior = FlyoutBehavior.Flyout;
            Items.Add(new ShellContent()
            {
                Title = "Home",
                ContentTemplate = new DataTemplate(typeof(HomePage)),
                Route = "MainPage",
                Icon = new FontImageSource()
                {
                    Glyph = "\xf1b0",
                    Color = Orange,
                    Size = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontFamily = "Fontello",
                    /*FontFamily = DeviceInfo.Platform.ToString() switch
                    {
                        nameof(DevicePlatform.Android) => "Fontello",
                        nameof(DevicePlatform.iOS) => "Fontello",
                        nameof(DevicePlatform.MacCatalyst) => "Fontello",
                        nameof(DevicePlatform.WinUI) => "Fontello",
                    }*/
                },
            });
            Items.Add(new ShellContent()
            {
                Title = "Donate",
                ContentTemplate = new DataTemplate(typeof(DonatePage)),
                Route = "Donate",
                Icon = new FontImageSource()
                {
                    Glyph = "\xe803",
                    Color = Red,
                    Size = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontFamily = "Fontello",
                    /*FontFamily = DeviceInfo.Platform.ToString() switch
                    {
                        nameof(DevicePlatform.Android) => "Fontello",
                        nameof(DevicePlatform.iOS) => "Fontello",
                        nameof(DevicePlatform.MacCatalyst) => "Fontello",
                        nameof(DevicePlatform.WinUI) => "Fontello",
                    }*/
                },
            });
            Items.Add(new ShellContent()
            {
                Title = "About",
                ContentTemplate = new DataTemplate(typeof(AboutPage)),
                Route = "About",
                Icon = new FontImageSource()
                {
                    Glyph = "\xe801",
                    Color = BlueViolet,
                    Size = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontFamily = "Fontello",
                    /*FontFamily = DeviceInfo.Platform.ToString() switch
                    {
                        nameof(DevicePlatform.Android) => "Fontello",
                        nameof(DevicePlatform.iOS) => "Fontello",
                        nameof(DevicePlatform.MacCatalyst) => "Fontello",
                        nameof(DevicePlatform.WinUI) => "Fontello",
                    }*/
                },
            });
        }
    }
}

