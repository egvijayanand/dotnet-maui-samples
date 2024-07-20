using DateCalculator.UI.Services;

namespace DateCalculator.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BindableProperties.Register();
            MainPage = new AppShell();
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			var window = base.CreateWindow(activationState);
			window.Title = "Date Calculator";
			return window;
		}
	}
}
