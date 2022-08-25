namespace Coffeeffee_MAUI.Controls
{
    public partial class Stepper : Frame
    {
        private void InitializeComponent()
        {
            HasShadow = false;
            VerticalOptions = LayoutOptions.Start;
            BackgroundColor = Color.FromArgb("#F1DFBF");
            this.Padding(16, 0).Height(40);
            Content = new Grid()
            {
                ColumnDefinitions = Columns.Define(20, Star, 20),
                Children =
                {
                    new Label()
                    {
                        Style = AppResource<Style>("counter"),
                        Text = "-",
                    },
                    new Label()
                    {
                        Style = AppResource<Style>("quantity"),
                    }.Column(1).Bind("Quantity"),
                    new Label()
                    {
                        Style = AppResource<Style>("counter"),
                        Text = "+",
                    }.Column(2),
                }
            };
        }
    }
}

