namespace MauiBMICalculator.Views
{
    public partial class ResultsPage : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "BMI Calculator - Result";
            Resources.Add("cvtUnderWeightBMI", new BMIOpacityConverter()
            {
                FromValue = 0f,
                ToValue = 18.9f,
            });
            Resources.Add("cvtNormalBMI", new BMIOpacityConverter()
            {
                FromValue = 19f,
                ToValue = 24.9f,
            });
            Resources.Add("cvtOverWeightBMI", new BMIOpacityConverter()
            {
                FromValue = 25f,
                ToValue = 29.9f,
            });
            Resources.Add("cvtObeseBMI", new BMIOpacityConverter()
            {
                FromValue = 30f,
                ToValue = 39.9f,
            });
            Resources.Add("cvtSeverlyObeseBMI", new BMIOpacityConverter()
            {
                FromValue = 40f,
                ToValue = 100f,
            });
            Content = new VerticalStackLayout()
            {
                Spacing = 32,
                IgnoreSafeArea = true,
                Children =
                {
                    new Label()
                    {
                        Text = "Your BMI is",
                        Style = AppResource<Style>("SectionHeaderStyle"),
                    }.CenterHorizontal(),
                    new Label()
                    {
                        Style = AppResource<Style>("BMIResultStyle"),
                    }.CenterHorizontal().Bind(nameof(ComputedBMI), BindingMode.OneWay, stringFormat: "{0:0.0}"),
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(Star,Star,Star,Star,Star),
                        RowDefinitions = Rows.Define(80, 44, 14),
                        ColumnSpacing = 12,
                        Children =
                        {
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(0).Row(0).Width(16).CenterHorizontal().FillVertical().Bind(nameof(AvatarImage), BindingMode.OneWay).Bind(Image.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtUnderWeightBMI"]),
                            new Label()
                            {
                                Text = @"Under
Weight",
                                Style = AppResource<Style>("ScaleHeaderStyle"),
                            }.Column(0).Row(1).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtUnderWeightBMI"]),
                            new Label()
                            {
                                Text = "< 19",
                                Style = AppResource<Style>("ScaleDisplayStyle"),
                            }.Column(0).Row(2).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtUnderWeightBMI"]),
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(1).Row(0).Width(20).CenterHorizontal().FillVertical().Bind(nameof(AvatarImage), BindingMode.OneWay).Bind(Image.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtNormalBMI"]),
                            new Label()
                            {
                                Text = "Normal",
                                Style = AppResource<Style>("ScaleHeaderStyle"),
                            }.Column(1).Row(1).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtNormalBMI"]),
                            new Label()
                            {
                                Text = "19 to 24",
                                Style = AppResource<Style>("ScaleDisplayStyle"),
                            }.Column(1).Row(2).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtNormalBMI"]),
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(2).Row(0).Width(24).CenterHorizontal().FillVertical().Bind(nameof(AvatarImage), BindingMode.OneWay).Bind(Image.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtOverWeightBMI"]),
                            new Label()
                            {
                                Text = @"Over
Weight",
                                Style = AppResource<Style>("ScaleHeaderStyle"),
                            }.Column(2).Row(1).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtOverWeightBMI"]),
                            new Label()
                            {
                                Text = "25 to 29",
                                Style = AppResource<Style>("ScaleDisplayStyle"),
                            }.Column(2).Row(2).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtOverWeightBMI"]),
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(3).Row(0).Width(29).CenterHorizontal().FillVertical().Bind(nameof(AvatarImage), BindingMode.OneWay).Bind(Image.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtObeseBMI"]),
                            new Label()
                            {
                                Text = "Obese",
                                Style = AppResource<Style>("ScaleHeaderStyle"),
                            }.Column(3).Row(1).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtObeseBMI"]),
                            new Label()
                            {
                                Text = "30 to 39",
                                Style = AppResource<Style>("ScaleDisplayStyle"),
                            }.Column(3).Row(2).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtObeseBMI"]),
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(4).Row(0).Width(35).CenterHorizontal().FillVertical().Bind(nameof(AvatarImage), BindingMode.OneWay).Bind(Image.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtSeverlyObeseBMI"]),
                            new Label()
                            {
                                Text = @"Severly
Obese",
                                Style = AppResource<Style>("ScaleHeaderStyle"),
                            }.Column(4).Row(1).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtSeverlyObeseBMI"]),
                            new Label()
                            {
                                Text = "> 40",
                                Style = AppResource<Style>("ScaleDisplayStyle"),
                            }.Column(4).Row(2).Bind(Label.OpacityProperty, nameof(ComputedBMI), converter: (IValueConverter)Resources["cvtSeverlyObeseBMI"]),
                        },
                    }.Margin(24,0),
                }
            }.Center();
        }
    }
}

