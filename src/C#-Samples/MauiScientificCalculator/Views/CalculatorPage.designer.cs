namespace MauiScientificCalculator.Views
{
    public partial class CalculatorPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "Scientific Calculator";
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Star,68,48,44,44,48,64,64,64,64),
                ColumnDefinitions = Columns.Define(Star,Star,Star,Star,Star),
                Children =
                {
                    new BoxView()
                    {
                        BackgroundColor = Color.FromArgb("#262D37"),
                    }.Row(1).ColumnSpan(5).Fill(),
                    new BoxView()
                    {
                        BackgroundColor = Color.FromArgb("#2C3240"),
                    }.Row(2).RowSpan(4).ColumnSpan(5).Fill(),
                    new Frame()
                    {
                        HasShadow = false,
                        BorderColor = AppResource<Color>("PrimaryColor"),
                        BackgroundColor = Color.FromArgb("#2C3240"),
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        Content = new Label()
                        {
                            LineHeight = 1.5,
                            FormattedText = new FormattedString()
                            {
                                Spans =
                                {
                                    new Span()
                                    {
                                        Style = AppResource<Style>("InputBoxLabelStyle"),
                                    }.Bind("InputText"),
                                    new Span()
                                    {
                                        Text = "\x2502",
                                        TextColor = AppResource<Color>("PrimaryColor"),
                                        Style = AppResource<Style>("InputBoxLabelStyle"),
                                    }.FontSize(28),
                                    new Span()
                                    {
                                        Text = "\x20",
                                        Style = AppResource<Style>("InputBoxLabelStyle"),
                                    },
                                },
                            },
                        }.CenterVertical().TextCenterVertical(),
                    }.Paddings(6,0,4,0).Margin(12).Row(0).Column(0).ColumnSpan(5),
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(Auto,Star),
                        Children =
                        {
                            new Label()
                            {
                                Text = "=",
                                Style = AppResource<Style>("EqualsLabelStyle"),
                            }.Margin(16,0).CenterVertical().TextCenterVertical(),
                            new Label()
                            {
                                Style = AppResource<Style>("ResultLabelStyle"),
                            }.Column(1).Margin(16,0).End().CenterVertical().TextCenterVertical().Bind("CalculatedResult", BindingMode.OneWay),
                        },
                    }.Row(1).Column(0).ColumnSpan(5),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "MEAN",
                    }.Row(2).Column(0).Margins(6,10,6,4),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "MOD",
                    }.Row(2).Column(1).Margins(6,10,6,4),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "STD",
                    }.Row(2).Column(2).Margins(6,10,6,4),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "VAR",
                    }.Row(2).Column(3).Margins(6,10,6,4),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "FACT",
                    }.Row(2).Column(4).Margins(6,10,6,4),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "SIN",
                    }.Row(3).Column(0).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "SIN"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "COS",
                    }.Row(3).Column(1).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "COS"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "TAN",
                    }.Row(3).Column(2).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "TAN"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "LOG",
                    }.Row(3).Column(3).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "LOG"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "EXP",
                    }.Row(3).Column(4).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "EXP"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "ASIN",
                    }.Row(4).Column(0).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "ASIN"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "ACOS",
                    }.Row(4).Column(1).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "ACOS"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "ATAN",
                    }.Row(4).Column(2).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "ATAN"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "LOG10",
                    }.Row(4).Column(3).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "LOG10"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "POW",
                    }.Row(4).Column(4).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "POW"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "SQRT",
                    }.Row(5).Column(0).Margins(6,4,6,10).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "SQRT"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "ABS",
                    }.Row(5).Column(1).Margins(6,4,6,10).BindCommandWithParameter("ScientificOperatorCommand", parameterValue: "ABS"),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = ",",
                    }.Row(5).Column(2).Margins(6,4,6,10).BindCommandWithParameter("RegionOperatorCommand", parameterValue: ","),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = "(",
                    }.Row(5).Column(3).Margins(6,4,6,10).BindCommandWithParameter("RegionOperatorCommand", parameterValue: "("),
                    new Button()
                    {
                        ZIndex = 1,
                        Style = AppResource<Style>("ScientificOperatorButtonStyle"),
                        Text = ")",
                    }.Row(5).Column(4).Margins(6,4,6,10).BindCommandWithParameter("RegionOperatorCommand", parameterValue: ")"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "AC",
                    }.Row(6).Column(3).ColumnSpan(2).Bind("ResetCommand"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "\xD7",
                    }.Row(7).Column(3).BindCommandWithParameter("MathOperatorCommand", parameterValue: "×"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "\xF7",
                    }.Row(7).Column(4).BindCommandWithParameter("MathOperatorCommand", parameterValue: "÷"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "+",
                    }.Row(8).Column(3).BindCommandWithParameter("MathOperatorCommand", parameterValue: "+"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "-",
                    }.Row(8).Column(4).BindCommandWithParameter("MathOperatorCommand", parameterValue: "-"),
                    new Button()
                    {
                        Style = AppResource<Style>("OperatorButtonStyle"),
                        Text = "=",
                    }.Row(9).Column(3).ColumnSpan(2).FontSize(28).Bind("CalculateCommand"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "7",
                    }.Row(6).Column(0).BindCommandWithParameter("NumberInputCommand", parameterValue: "7"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "8",
                    }.Row(6).Column(1).BindCommandWithParameter("NumberInputCommand", parameterValue: "8"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "9",
                    }.Row(6).Column(2).BindCommandWithParameter("NumberInputCommand", parameterValue: "9"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "4",
                    }.Row(7).Column(0).BindCommandWithParameter("NumberInputCommand", parameterValue: "4"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "5",
                    }.Row(7).Column(1).BindCommandWithParameter("NumberInputCommand", parameterValue: "5"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "6",
                    }.Row(7).Column(2).BindCommandWithParameter("NumberInputCommand", parameterValue: "6"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "1",
                    }.Row(8).Column(0).BindCommandWithParameter("NumberInputCommand", parameterValue: "1"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "2",
                    }.Row(8).Column(1).BindCommandWithParameter("NumberInputCommand", parameterValue: "2"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "3",
                    }.Row(8).Column(2).BindCommandWithParameter("NumberInputCommand", parameterValue: "3"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "0",
                    }.Row(9).Column(0).BindCommandWithParameter("NumberInputCommand", parameterValue: "0"),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = ".",
                    }.Row(9).Column(1).BindCommandWithParameter("NumberInputCommand", parameterValue: "."),
                    new Button()
                    {
                        Style = AppResource<Style>("NumberButtonStyle"),
                        Text = "\x232B",
                    }.Row(9).Column(2).Bind("BackspaceCommand"),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("BorderColor"),
                    }.Row(6).Column(0).ColumnSpan(3).Height(1).FillHorizontal().Bottom(),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("BorderColor"),
                    }.Row(7).Column(0).ColumnSpan(3).Height(1).FillHorizontal().Bottom(),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("BorderColor"),
                    }.Row(8).Column(0).ColumnSpan(3).Height(1).FillHorizontal().Bottom(),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("BorderColor"),
                    }.Row(6).RowSpan(4).Column(0).Width(1).End().FillVertical(),
                    new BoxView()
                    {
                        BackgroundColor = AppResource<Color>("BorderColor"),
                    }.Row(6).RowSpan(4).Column(1).Width(1).End().FillVertical(),
                }
            };
        }
    }
}

