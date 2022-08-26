using System;
using System.Windows.Input;

namespace UIMock
{
    public class LoginPageViewModel : BaseViewModel
    {
        public ICommand ICommandNavToHomePage { get; set; }

        public LoginPageViewModel()
        {
            ICommandNavToHomePage = new Command(() => NavigateToHomePage());
        }

        private void NavigateToHomePage()
        {
            App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}

