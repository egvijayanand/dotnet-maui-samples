using System;
using SpaceXhistory.Models;
using System.Collections.ObjectModel;
using SpaceXhistory.Helpers;
using Newtonsoft.Json;

namespace SpaceXhistory.ViewModels
{
	public class UpcomingLaunchesViewModel : BaseViewModel
	{
		public ObservableCollection<Root> NextLaunchs { get; set; }

		private readonly HttpClient _client;

		public UpcomingLaunchesViewModel()
		{
			_client = new HttpClient();
			NextLaunchs = new ObservableCollection<Root>();
        }

		public void PopulateNextLaunchs()
		{
			foreach(Root lauch in RetriveAllNextLaunchs())
			{
				NextLaunchs.Add(lauch);
            }
		}

		private ObservableCollection<Root> RetriveAllNextLaunchs()
		{
			var nextLaunchsSerialized = _client.GetStringAsync(Constants.BaseUrl + "launches/upcoming").Result;
			var nextLaunchsDeserialized = JsonConvert.DeserializeObject<List<Root>>(nextLaunchsSerialized);

			ObservableCollection<Root> allLaunchs = new(nextLaunchsDeserialized);

			return allLaunchs;
        }
	}
}

