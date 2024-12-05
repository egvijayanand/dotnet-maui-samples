namespace TitleBarApp.Views
{
    public partial class XamlPage : ContentPage
    {
        public XamlPage()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
            Window.TitleBar = new MyTitleBar();
		}
	}
}
