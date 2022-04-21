using System;
using Xamarin.Forms;

namespace DateCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//settings");
        }
    }
}
