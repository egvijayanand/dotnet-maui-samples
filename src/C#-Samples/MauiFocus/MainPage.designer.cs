namespace MauiFocus
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Spacing = 25,
                    Children =
                    {
                        new Image()
                        {
                            Source = "bonsai.jpg",
                        }.Height(200).CenterHorizontal().SemanticDesc("A nice bonsai!"),
                        new Label()
                        {
                            Text = "Focus!",
                        }.FontSize(32).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level1),
                        new Label()
                        {
                            Text = "Remember to turn off your distractions while focusing",
                        }.FontSize(18).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level2).SemanticDesc("Welcome to dot net Multi platform App U I"),
                        new VerticalStackLayout()
                        {
                            Spacing = 25,
                            Children =
                            {
                                new VerticalStackLayout()
                                {
                                    Children =
                                    {
                                        new Label()
                                        {
                                            Text = "Click the '+' sign.",
                                        }.Center().Assign(out _displayLabel),
                                        new Stepper()
                                        {
                                            Maximum = 120,
                                            Increment = 1,
                                        }.CenterHorizontal().Assign(out _stepper).Invoke(x => x.ValueChanged += OnStepperValueChanged),
                                        new Button()
                                        {
                                            IsEnabled = false,
                                            Text = "Go!",
                                        }.Assign(out StartButton).Invoke(btn => btn.Clicked += StartButton_Clicked),
                                    },
                                }.CenterHorizontal(),
                            },
                        }.Padding(30,0).Assign(out OptionsPanel),
                        new VerticalStackLayout()
                        {
                            IsVisible = false,
                            Spacing = 25,
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Starting timer...",
                                }.Assign(out _timeLeftLabel),
                                new Button()
                                {
                                    Text = "Stop!",
                                }.Assign(out StopButton).Invoke(btn => btn.Clicked += StopButton_Clicked),
                            },
                        }.Padding(30,0).CenterHorizontal().Assign(out CountdownPanel),
                    }
                }.Padding(30,0).CenterVertical()
            };
        }

        #region Variables
        private VerticalStackLayout OptionsPanel;
        private Label _displayLabel;
        private Stepper _stepper;
        private Button StartButton;
        private VerticalStackLayout CountdownPanel;
        private Label _timeLeftLabel;
        private Button StopButton;
        #endregion
    }
}

