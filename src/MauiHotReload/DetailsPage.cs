namespace MauiHotReload
{
	public class DetailsPage : MauiPage
	{
		protected override void Build()
		{
			Title = "Details";
			Content = new Grid()
			{
				Children =
				{
					new Label()
					{
						Text = "Details Page"
					}.Center()
				}
			};
		}
	}
}
