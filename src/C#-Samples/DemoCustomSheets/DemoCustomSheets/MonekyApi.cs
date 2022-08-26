using System.Text.Json.Serialization;

namespace DemoCustomSheets
{
    internal class MonekyApi
    {
        public class MonkeyApi
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Details { get; set; }
            public string Image { get; set; }
            public int Population { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            [JsonIgnore]
            public bool ButtonEnabel => IsAllFill();

            private bool IsAllFill()
            {
                return !string.IsNullOrWhiteSpace(Latitude.ToString()) && !string.IsNullOrWhiteSpace(Longitude.ToString());
            }
        }
    }
}
