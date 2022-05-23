using DateCalculator.UI.Services;
using DateCalculator.UI.Views;

namespace DateCalculator.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BindableProperties.Register();
            MainPage = new DatePage();
        }
    }
}
