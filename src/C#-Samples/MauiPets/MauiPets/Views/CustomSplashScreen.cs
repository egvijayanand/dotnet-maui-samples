namespace MAUIPETS.Views;

public partial class CustomSplashScreen : ContentPage
{
	public CustomSplashScreen()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        await Task.Delay(1000);

        var anim1 = pets.TranslateTo(400, 0, 3000, Easing.Linear);
        var anim2 = pets.ScaleTo(1.5, 3000, Easing.Linear);

        await Task.WhenAll(anim1, anim2);

        App.Current.MainPage = new AppShell();
    }
}
