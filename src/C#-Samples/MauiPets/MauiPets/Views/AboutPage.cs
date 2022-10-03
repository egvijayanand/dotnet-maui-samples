namespace MAUIPETS.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
        LabelName.Text = "Name: " + $"{AppInfo.Name}";

        LabelVersion.Text = "Version " + $"{AppInfo.VersionString} " +
            $"{AppInfo.BuildString}";
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
