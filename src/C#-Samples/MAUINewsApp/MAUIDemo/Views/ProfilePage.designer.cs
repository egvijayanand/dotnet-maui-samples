namespace MAUIDemo.Views
{
    public partial class ProfilePage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Account";
            Resources.Add(new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.HeightRequestProperty, Value = 1 },
                    new() { Property = BoxView.ColorProperty, Value = AppResource<Color>("Gray200") },
                    new() { Property = BoxView.MarginProperty, Value = new Thickness(-20,10) },
                },
            });
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Children =
                    {
                        new Label()
                        {
                            Text = "SUBSCRIBER",
                            FontFamily = "PoppinsSemibold",
                            TextColor = AppResource<Color>("Gray300"),
                        },
                        new Label()
                        {
                            Text = "Jesse Smith",
                            FontFamily = "PoppinsBold",
                        }.FontSize(20),
                        new BoxView(),
                        new Label()
                        {
                            Text = "Edit Subscription Details",
                        },
                        new BoxView(),
                        new ContentView().Height(20),
                        new Label()
                        {
                            Text = "APP SETTINGS",
                            FontFamily = "PoppinsSemibold",
                            TextColor = AppResource<Color>("Gray300"),
                        },
                        new BoxView(),
                        new Label()
                        {
                            Text = "Push Notifications",
                        },
                        new BoxView(),
                        new Label()
                        {
                            Text = "Display Settings",
                        },
                        new BoxView(),
                        new ContentView().Height(20),
                        new Label()
                        {
                            Text = "SUPPORT",
                            FontFamily = "PoppinsSemibold",
                            TextColor = AppResource<Color>("Gray300"),
                        },
                        new BoxView(),
                        new Label()
                        {
                            Text = "Frequently Asked Questions",
                        },
                        new BoxView(),
                        new Label()
                        {
                            Text = "Report a Bug",
                        },
                        new BoxView(),
                        new Label()
                        {
                            Text = "Submit a Question",
                        },
                        new BoxView(),
                        new ContentView().Height(40),
                        new BoxView(),
                        new Label()
                        {
                            Text = "Log Out",
                        },
                        new BoxView(),
                    }
                }.Padding(20)
            };
        }
    }
}

