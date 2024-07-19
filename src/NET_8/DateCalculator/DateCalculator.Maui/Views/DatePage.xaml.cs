using System.Reflection;

namespace DateCalculator.Views
{
    public partial class DatePage : MauiPage
    {
        public DatePage()
        {
            InitializeComponent();
			var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
			mauiVersion.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
		}

		private async void OnHelpMenuItemClicked(object sender, EventArgs e)
		{
			await DisplayAlert("Alert", "Hello there.", "OK");
        }
    }
}
