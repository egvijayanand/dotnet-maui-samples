namespace MauiBMICalculator.Views
{
    public partial class Step2Page : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "BMI Calculator - Step 2";
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(80,Star,140),
                Children =
                {
                    new Label()
                    {
                        Text = "Your height & weight",
                        Style = AppResource<Style>("SectionHeaderStyle"),
                    }.Row(0).Margins(0,0,0,16).CenterHorizontal().Bottom(),
                    new Grid()
                    {
                        ColumnDefinitions = Columns.Define(100,Star,100),
                        Children =
                        {
                            new VerticalGuage()
                            {
                                Maximum = 220,
                                Minimum = 120,
                                Step = 10f,
                                MinorTicks = 4f,
                                IndicatorValueUnit = "cm",
                                IndicatorDirection = "Right",
                            }.Column(0).Width(100).Height(250).Start().Top().Bind(VerticalGuage.IndicatorValueProperty, nameof(Step2PageViewModel.SelectedHeight), BindingMode.TwoWay).Assign(out HeightControl),
                            new Image()
                            {
                                Aspect = Aspect.Fill,
                            }.Column(1).CenterHorizontal().Bottom().Bind(nameof(Step2PageViewModel.AvatarImage), BindingMode.OneWay).Assign(out AvatarImage),
                            new VerticalGuage()
                            {
                                Maximum = 200,
                                Minimum = 40,
                                Step = 20f,
                                MinorTicks = 4f,
                                IndicatorValueUnit = "kg",
                                IndicatorDirection = "Left",
                            }.Column(2).Width(100).Height(200).End().Bottom().Bind(VerticalGuage.IndicatorValueProperty, nameof(Step2PageViewModel.SelectedWeight), BindingMode.TwoWay).Assign(out WeightControl),
                        },
                    }.Row(1).Margin(24).Padding(0,36).Fill().Assign(out SelectionGrid),
                    new ImageButton()
                    {
                        Style = AppResource<Style>("NextButtonStyle"),
                    }.Row(2).Center().Bind(nameof(Step2PageViewModel.CalculateBMICommand), BindingMode.OneWay),
                }
            }.Fill();
        }

        #region Variables
        private Grid SelectionGrid;
        private VerticalGuage HeightControl;
        private Image AvatarImage;
        private VerticalGuage WeightControl;
        #endregion
    }
}

