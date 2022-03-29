namespace TestApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnLogoutClicked(object sender, EventArgs e)
        {
            App.Instance!.User.Authenticated = false;
        }
    }
}
