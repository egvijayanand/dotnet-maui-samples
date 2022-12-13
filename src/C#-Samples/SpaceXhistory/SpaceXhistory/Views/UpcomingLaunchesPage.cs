using SpaceXhistory.ViewModels;
using SpaceXhistory.Models;

namespace SpaceXhistory.Views;

public partial class UpcomingLaunchesPage : ContentPage
{
	private readonly UpcomingLaunchesViewModel _viewModel;

	public UpcomingLaunchesPage()
	{
		InitializeComponent();

		_viewModel = new UpcomingLaunchesViewModel();
		BindingContext = _viewModel;

        _viewModel.PopulateNextLaunchs();
    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is not Root launch || string.IsNullOrEmpty(launch.links.webcast))
        {
            await DisplayAlert(string.Empty, "This release does not yet have a video.", "Ok");
            return;
        }

        try
        {
            Uri uri = new(launch.links.webcast);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Console.Write(ex.Data);

            await DisplayAlert("An unexpected error occured",
                "No browser may be installed on the device",
                "Ok");
        }
    }
}
