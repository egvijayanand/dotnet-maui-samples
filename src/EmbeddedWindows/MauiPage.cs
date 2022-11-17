using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Markup;
using static Microsoft.Maui.Graphics.Colors;

namespace EmbeddedWindows
{
	public class MauiPage : ContentPage
	{
		public MauiPage()
		{
			Content = new Grid
			{
				Children =
				{
					new Label
					{
						Text = "Hello .NET MAUI!!!"
					}.Center().TextColor(Purple)
				}
			};
		}
	}
}
