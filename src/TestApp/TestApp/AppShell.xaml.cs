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
            if (App.Instance is not null)
            {
                App.Instance.User.Authenticated = false;
            }
        }
    }
}
