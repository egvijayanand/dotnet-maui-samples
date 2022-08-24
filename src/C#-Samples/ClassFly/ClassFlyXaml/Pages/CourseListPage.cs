using ClassFly.Core.Models;
using System.Diagnostics;

namespace ClassFlyXaml.Pages;

public partial class CourseListPage : ContentPage
{
	public CourseListPage()
	{
		InitializeComponent();
	}

	protected override void OnSizeAllocated(double width, double height)
	{
		base.OnSizeAllocated(width, height);

		// Fix for issue with search bar not sizing
		// https://github.com/dotnet/maui/issues/7137
		if (DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
		{
			if (width > 0)
				CourseSearchBar.WidthRequest = width;
		}
	}
}