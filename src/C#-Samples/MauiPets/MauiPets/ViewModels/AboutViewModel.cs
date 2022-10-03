using System;
using System.Windows.Input;

namespace MAUIPETS.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://docs.microsoft.com/en-us/dotnet/maui/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}