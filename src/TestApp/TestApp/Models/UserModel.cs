namespace TestApp.Models
{
    public class UserModel : ObservableObject
    {
        private string _username;
        private bool? _authenticated;

        public UserModel()
        {
            _username = string.Empty;
            _authenticated = null;
        }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public bool? Authenticated
        {
            get => _authenticated;
            set => SetProperty(ref _authenticated, value, onChanged: async () =>
            {
                if (value is true)
                {
                    await Shell.Current.GoToAsync("//home");
                }
                else
                {
                    await Shell.Current.GoToAsync("//login");
                }
            });
        }
    }
}
