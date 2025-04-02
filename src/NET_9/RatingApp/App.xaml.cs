namespace RatingApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        UserAppTheme = PlatformAppTheme;
    }

    protected override Window CreateWindow(IActivationState? activationState)
        => new()
        {
            Page = new MainPage(),
            Title = "RatingApp"
        };
}
