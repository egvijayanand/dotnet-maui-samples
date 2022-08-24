using ClassFlyXaml.Pages;

namespace ClassFlyXaml;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CoursePage), typeof(CoursePage));
	}
}
