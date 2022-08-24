namespace ClassFlyXaml;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        DefaultBindableProperties.RegisterForCommand(
            (EventToCommandBehavior.CommandProperty, EventToCommandBehavior.CommandParameterProperty)
        );

        MainPage = new AppShell();

    }
}
