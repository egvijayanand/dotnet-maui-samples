using System;
using SpaceXhistory.Models;
using SpaceXhistory.Helpers;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace SpaceXhistory.ViewModels
{
	public class PastLaunchesViewModel : BaseViewModel
	{
        public ObservableCollection<Root> LatestLaunchs { get; set; }

        private readonly HttpClient _client;

        public PastLaunchesViewModel()
		{
			_client = new HttpClient();
            LatestLaunchs = new ObservableCollection<Root>();
        }

        public void PopulateLatestLaunchs()
        {
            foreach (Root lauch in RetriveAllLatestLaunchs())
            {
                LatestLaunchs.Add(lauch);
            }
        }

        private ObservableCollection<Root> RetriveAllLatestLaunchs()
        {
            var latestLaunchsSerialized = _client.GetStringAsync(Constants.BaseUrl + "launches/past").Result;
            var latestLaunchsDeserialized = JsonConvert.DeserializeObject<List<Root>>(latestLaunchsSerialized);

            ObservableCollection<Root> allLaunchs = new(latestLaunchsDeserialized);

            return allLaunchs;
        }
    }
}

