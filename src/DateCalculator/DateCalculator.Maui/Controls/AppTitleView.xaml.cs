using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;

namespace DateCalculator.Controls
{
    public partial class AppTitleView : ContentView, IView
    {
        public static readonly BindableProperty PageTitleProperty
            = BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(AppTitleView), default(string));

        public AppTitleView()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get => (string)GetValue(PageTitleProperty);
            set => SetValue(PageTitleProperty, value);
        }

        private void Hamburger_Tapped(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
        }
    }
}
