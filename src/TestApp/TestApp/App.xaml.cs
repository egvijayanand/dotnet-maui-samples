using Application = Microsoft.Maui.Controls.Application;

namespace TestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
