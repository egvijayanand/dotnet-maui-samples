namespace MauiBMICalculator.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();

        BindingContext = new StartPageViewModel(Navigation, this);
    }
}
