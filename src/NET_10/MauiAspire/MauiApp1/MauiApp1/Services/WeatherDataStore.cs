namespace MauiApp1.Services
{
    public partial class WeatherDataStore(IHttpClientFactory clientFactory) : IDataStore<WeatherForecast>
    {
        private readonly HttpClient httpClient = clientFactory.CreateClient("webapi");

        public Task<bool> AddItemAsync(WeatherForecast item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WeatherForecast>> GetItemsAsync(bool forceRefresh = false)
        {
            var responseText = await httpClient.GetStringAsync("/weatherforecast");
            return Serializer.ToObject<IEnumerable<WeatherForecast>>(responseText) ?? [];
        }

        public Task<bool> UpdateItemAsync(WeatherForecast item)
        {
            throw new NotImplementedException();
        }
    }
}
