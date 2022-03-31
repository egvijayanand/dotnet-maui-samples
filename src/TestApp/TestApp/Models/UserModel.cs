namespace TestApp.Models
{
    public class UserModel : ObservableObject
    {
        private string _username;
        private bool? _authenticated;

        private readonly INavigationService? _navigationService;

        public UserModel()
        {
            _username = string.Empty;
            _authenticated = null;
            _navigationService = AppService.GetService<INavigationService>();
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
                if (_navigationService is not null)
                {
                    if (value is true)
                    {
                        await _navigationService.GoToAsync("//home");
                    }
                    else
                    {
                        await _navigationService.GoToAsync("//login");
                    }
                }
            });
        }
    }
}
