namespace MauiBMICalculator.Views
{
    public partial class StartPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "BMI Calculator - Step 1";
            Content = new VerticalStackLayout()
            {
                Spacing = 64,
                IgnoreSafeArea = true,
                Children =
                {
                    new Label()
                    {
                        Text = "Choose your Gender",
                        Style = AppResource<Style>("SectionHeaderStyle"),
                    }.CenterHorizontal(),
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(Auto, 48, Auto),
                        Children =
                        {
                            new ContentView()
                            {
                                Content = new Ellipse()
                                {
                                    Fill = AppResource<Color>("LightBackgroundColor"),
                                    StrokeThickness = 0,
                                    InputTransparent = true,
                                }.Fill(),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommandWithParameter(nameof(StartPageViewModel.SelectGenderCommand), parameterValue: "Male"),
                                },
                            }.Column(0).Width(140).Height(140).CenterHorizontal().Bottom(),
                            new Image()
                            {
                                Source = "male.png",
                                InputTransparent = true,
                            }.Column(0).Height(195).Width(50).Margins(0,0,0,16).CenterHorizontal().Bottom(),
                            new Image()
                            {
                                Source = "checkedicon.png",
                            }.Column(0).Width(24).Height(24).Margins(0,0,12,12).End().Top().Bind(Image.IsVisibleProperty, nameof(StartPageViewModel.IsMaleSelected), BindingMode.OneWay),
                            new ContentView()
                            {
                                Content = new Ellipse()
                                {
                                    Fill = AppResource<Color>("LightBackgroundColor"),
                                    StrokeThickness = 0,
                                    InputTransparent = true,
                                }.Fill(),
                                GestureRecognizers =
                                {
                                    new TapGestureRecognizer().BindCommandWithParameter(nameof(StartPageViewModel.SelectGenderCommand), parameterValue: "Female"),
                                },
                            }.Column(2).Width(140).Height(140).CenterHorizontal().Bottom(),
                            new Image()
                            {
                                Source = "female.png",
                                InputTransparent = true,
                            }.Column(2).Height(195).Width(50).Margins(0,0,0,16).CenterHorizontal().Bottom(),
                            new Image()
                            {
                                Source = "checkedicon.png",
                            }.Column(2).Width(24).Height(24).Margins(0,0,12,12).End().Top().Bind(Image.IsVisibleProperty, nameof(StartPageViewModel.IsFemaleSelected), BindingMode.OneWay),
                        },
                    },
                    new ImageButton()
                    {
                        Style = AppResource<Style>("NextButtonStyle"),
                    }.CenterHorizontal().Bind(nameof(StartPageViewModel.GotoStep2Command), BindingMode.OneWay),
                }
            }.Center();
        }
    }
}

