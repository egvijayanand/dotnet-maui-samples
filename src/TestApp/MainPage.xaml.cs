using System;
using TestApp.Core;
using Microsoft.Maui.Controls.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MauiPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;

        private void OnButtonClicked(object sender, EventArgs e)
        {
            count++;
            CountLabel.Text = $"You clicked {count} times!";
        }
    }
}
