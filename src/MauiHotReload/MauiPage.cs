namespace MauiHotReload
{
	public abstract class MauiPage : ContentPage
	{
		public MauiPage()
		{
			Build();
#if DEBUG
			if (Application.Current is not null)
			{
				// Not a NavigationPage / TabbedPage / Shell
				if (Application.Current.MainPage is ContentPage)
				{
					HotReloadService.UpdateApplicationEvent += Refresh;
				}
			}
#endif
		}

		protected abstract void Build();

		protected override void OnNavigatedTo(NavigatedToEventArgs args)
		{
			base.OnNavigatedTo(args);
#if DEBUG
			HotReloadService.UpdateApplicationEvent += Refresh;
#endif
		}

		protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
		{
			base.OnNavigatedFrom(args);
#if DEBUG
			HotReloadService.UpdateApplicationEvent -= Refresh;
#endif
		}

		private void Refresh(Type[]? obj) => Dispatcher.Dispatch(Build);

		public void Dispose()
		{
#if DEBUG
			HotReloadService.UpdateApplicationEvent -= Refresh;
#endif
		}
	}
}
