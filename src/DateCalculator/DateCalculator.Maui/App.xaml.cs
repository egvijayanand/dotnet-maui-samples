using DateCalculator.Views;
using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace DateCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new HomePage());
            MainPage = new AppShell();
        }
    }
}
