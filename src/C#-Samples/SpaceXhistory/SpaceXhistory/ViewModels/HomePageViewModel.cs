using System;
using Newtonsoft.Json;
using SpaceXhistory.Helpers;
using SpaceXhistory.Models;

namespace SpaceXhistory.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		public Root NextLaunch
		{
			get => _nextLaunch;
			set => SetProperty(ref _nextLaunch, value);
		}

		public Root LatestLaunch
		{
			get => _latestLaunch;
			set => SetProperty(ref _latestLaunch, value);
		}

		public Roadster RoadsterInfo
		{
			get => _roadsterInfo;
			set => SetProperty(ref _roadsterInfo, value);
		}

        private readonly HttpClient _client;
		private Root _nextLaunch;
		private Root _latestLaunch;
		private Roadster _roadsterInfo;

		public HomePageViewModel()
		{
			_client = new HttpClient();
		}

		public void GetNextLaunch()
		{
            var nextLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "launches/next").Result;
            NextLaunch = JsonConvert.DeserializeObject<Root>(nextLaunchSerialized);
        }

		public void GetLatestLaunch()
		{
            var lastedLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "launches/latest").Result;
            LatestLaunch = JsonConvert.DeserializeObject<Root>(lastedLaunchSerialized);
        }

		public void GetRoadsterInfo()
		{
			var roadsterInfoSerialized = _client.GetStringAsync(Constants.BaseUrl + "roadster").Result;
            RoadsterInfo = JsonConvert.DeserializeObject<Roadster>(roadsterInfoSerialized);
        }
    }
}

