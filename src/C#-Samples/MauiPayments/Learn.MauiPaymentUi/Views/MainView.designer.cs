namespace Learn.MauiPaymentUi.Views
{
    public partial class MainView : ContentPage
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
                            Source = "dotnet_bot.png",
                        }.Height(200).CenterHorizontal().SemanticDesc("Cute dot net bot waving hi to you!"),
                        new Label()
                        {
                            Text = "Payments with Prism.MAUI!",
                        }.FontSize(32).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level1).SemanticDesc("Welcome to Prism for dot net Multi platform App UI"),
                        new Label()
                        {
                            Text = "Select items to purchse below",
                        }.FontSize(18).CenterHorizontal().SemanticHeading(SemanticHeadingLevel.Level2).SemanticDesc("Select items"),
                        new Border()
                        {
                            Content = new Grid()
                            {
                                ColumnDefinitions = Columns.Define(Auto,Star),
                                RowDefinitions = Rows.Define(Auto,Auto,Auto),
                                Children =
                                {
                                    new CheckBox().Row(0).Bind(nameof(MainViewModel.Item1Checked)),
                                    new Label()
                                    {
                                        Text = "Hat - $10",
                                    }.Row(0).Column(1),
                                    new CheckBox().Row(1).Bind(nameof(MainViewModel.Item2Checked)),
                                    new Label()
                                    {
                                        Text = "Shirt - $10",
                                    }.Row(1).Column(1),
                                    new CheckBox().Row(2).Bind(nameof(MainViewModel.Item3Checked)),
                                    new Label()
                                    {
                                        Text = "Shoes - $10",
                                    }.Row(2).Column(1),
                                },
                            }.CenterHorizontal(),
                        }.Padding(10,10).CenterHorizontal(),
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Button()
                                {
                                    Text = "Reset",
                                }.CenterHorizontal().Bind(nameof(MainViewModel.CmdResetCart)),
                                new Button()
                                {
                                    Text = "Check Out",
                                }.CenterHorizontal().Bind(nameof(MainViewModel.CmdCheckout)),
                            },
                        }.CenterHorizontal(),
                    }
                }.Padding(30,0).CenterVertical()
            };
        }
    }
}

