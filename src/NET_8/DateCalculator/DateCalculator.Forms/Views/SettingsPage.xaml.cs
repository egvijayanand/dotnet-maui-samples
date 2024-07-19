using System;
using Xamarin.Forms;

namespace DateCalculator.Views
{
    public partial class SettingsPage : BasePage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//home");
        }
    }
}