namespace UIMock
{
    public partial class LoginPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "LoginPage";
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = White;
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Stars(1), Stars(2)),
                Children =
                {
                    new Image()
                    {
                        Source = "icon.png",
                        Aspect = Aspect.AspectFit,
                    }.Row(0).Height(100).Center(),
                    new VerticalStackLayout()
                    {
                        Spacing = 10,
                        Children =
                        {
                            new Label()
                            {
                                Text = "Log In To Medicoer",
                                TextColor = Black,
                                FontAttributes = FontAttributes.Bold,
                            }.FontSize(20).Margins(0,0,0,20).CenterHorizontal(),
                            new Label()
                            {
                                Text = "Your Email",
                            },
                            new Entry()
                            {
                                Placeholder = "youremail@domain.com",
                                Keyboard = Keyboard.Email,
                            },
                            new Label()
                            {
                                Text = "Password",
                            },
                            new Entry()
                            {
                                Placeholder = "password",
                                IsPassword = true,
                            },
                            new Label()
                            {
                                Text = "Forgot password?",
                                TextColor = Gray,
                            }.FontSize(NamedSize.Small).End(),
                            new Button()
                            {
                                Text = "Log In",
                                BackgroundColor = Color.FromArgb("#e8bc65"),
                            }.Margins(0,10,0,0).Bind("ICommandNavToHomePage"),
                            new Label()
                            {
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                FormattedText = new FormattedString()
                                {
                                    Spans =
                                    {
                                        new Span()
                                        {
                                            Text = "New User? ",
                                            TextColor = Gray,
                                        },
                                        new Span()
                                        {
                                            Text = "Create Account",
                                            TextColor = Color.FromArgb("#7d87f1"),
                                        },
                                    },
                                },
                            }.Margins(0,10,0,0),
                        },
                    }.Row(1),
                }
            }.Margin(40);
        }
    }
}

