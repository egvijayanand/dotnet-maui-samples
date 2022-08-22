using BeautyShopApp.Views;

namespace BeautyShopApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());
	}
}
