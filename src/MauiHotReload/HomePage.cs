namespace MauiHotReload
{
	public class HomePage : MauiPage
	{
		protected override void Build()
		{
			Title = "Home";
			Content = new Grid
			{
				RowDefinitions = Rows.Define(Star, Star, Star, Star),
				ColumnDefinitions = Columns.Define(Star, Star),
				Children =
				{
					new Label
					{
						Text = "Landing Page",
					}.Row(0).ColumnSpan(2).Center(),
					new Label
					{
						Text = "Hot reloaded label in row 2 spanning two columns",
					}.Row(1).ColumnSpan(2).Center(),
					new Button
					{
						Text = "Go to details",
						Style = AppStyle("PrimaryAction"),
					}.Row(2).Column(0).Center().Invoke(btn => btn.Clicked += OnClicked),
					new Label
					{
						Text = "Hot reloaded label in row 3 column 2 with text aligned at the end",
					}.Row(2).Column(1).End().CenterVertical(),
					new Label
					{
						Text = "Hot reloaded label in row 4 spanning two columns",
					}.Row(3).ColumnSpan(2).Center()
				}
			};
		}

		private async void OnClicked(object? sender, EventArgs e)
		{
			await Navigation.PushAsync(new DetailsPage());
		}
	}
}
