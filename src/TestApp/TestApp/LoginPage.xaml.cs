namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            if (App.Instance is not null)
            {
                App.Instance.User.Authenticated = true;
            }
        }
    }
}
