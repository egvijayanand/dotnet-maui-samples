namespace ClassFlyXaml.Resources.Styles
{
    public partial class AppStyles : ResourceDictionary
    {
        private void InitializeComponent()
        {
            Add("TabBarDark", Color.FromArgb("#384054"));
            Add("TabBarLight", Color.FromArgb("#505A70"));
            Add("EvenRowColor", Color.FromArgb("#278C7E"));
            Add("OddRowColor", Color.FromArgb("#FFD051"));
            Add("TabBarGradient", new LinearGradientBrush()
            {
                StartPoint = new Point(0,0),
                EndPoint = new Point(1,1),
                GradientStops =
                {
                    new GradientStop()
                    {
                        Offset = 0.1f,
                        Color = (Color)this["TabBarLight"],
                    },
                    new GradientStop()
                    {
                        Offset = 1.0f,
                        Color = (Color)this["TabBarDark"],
                    },
                }
            });
            Add("WhiteFadeGradient", new LinearGradientBrush()
            {
                StartPoint = new Point(0,0),
                EndPoint = new Point(0,1),
                GradientStops =
                {
                    new GradientStop()
                    {
                        Offset = 0.0f,
                        Color = White,
                    },
                    new GradientStop()
                    {
                        Offset = 1.0f,
                        Color = Color.FromArgb("#00FFFFFF"),
                    },
                }
            });
            Add("CourseHeaderText", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 30 },
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontFamilyProperty, Value = "SFUIText-Medium" },
                },
            });
            Add("CourseSmallText", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                    new() { Property = Label.TextColorProperty, Value = Black },
                    new() { Property = Label.FontFamilyProperty, Value = "SFUIText-Regular" },
                },
            });
            Add(new Style(typeof(TabBar))
            {
                Setters =
                {
                    new() { Property = Shell.TabBarBackgroundColorProperty, Value = CornflowerBlue },
                    new() { Property = Shell.TabBarTitleColorProperty, Value = Black },
                    new() { Property = Shell.TabBarUnselectedColorProperty, Value = AntiqueWhite },
                },
            });
        }
    }
}

