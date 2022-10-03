using MAUIPETS.Views;

namespace MAUIPETS;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(PetDetailsView), typeof(PetDetailsView));
	}
}

