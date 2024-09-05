namespace WinUIBlazor
{
    public partial class MyApp : Application
    {
        public MyApp()
        {
            InitializeComponent();
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
            => new Window(new MainPage()) { Title = "WinUIBlazor" };
    }
}
