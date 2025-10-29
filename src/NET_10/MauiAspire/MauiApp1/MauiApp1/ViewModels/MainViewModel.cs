using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels
{
    public partial class MainViewModel(WeatherDataStore dataStore) : BaseViewModel
    {
        public ObservableCollection<WeatherForecast> Forecasts { get; } = [];

        [RelayCommand]
        public async Task ForecastsAsync()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
                Forecasts.Clear();
                var forecasts = await dataStore.GetItemsAsync();

                foreach (var forecast in forecasts)
                {
                    Forecasts.Add(forecast);
                }
            }
            catch (Exception)
            {
                // Handle exceptions (e.g., log them)
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
