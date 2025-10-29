using System.Text.Json.Serialization;

namespace MauiApp1.Models
{
    public class WeatherForecast
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; init; }

        [JsonPropertyName("temperatureC")]
        public int TemperatureC { get; init; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [JsonPropertyName("summary")]
        public string? Summary { get; init; }
    }
}
