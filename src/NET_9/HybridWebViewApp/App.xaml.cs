﻿namespace HybridWebViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
            => new Window(new MainPage()) { Title = "HybridWebViewApp" };
    }
}