namespace TitleBarApp.Views
{
    public partial class CSharpPage : ContentPage
    {
        public CSharpPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Window.TitleBar = new TitleBar()
            {
                ForegroundColor = AppColor("White"),
                LeadingContent = new Grid()
                {
                    ColumnDefinitions = Columns.Define(Auto, Auto, Auto),
                    ColumnSpacing = 15d,
                    Children =
                        {
                            new Image()
                            {
                                Source = "dotnet_bot.png",
                            }.Size(16),
                            new Label().Column(1)
                             .Text("MyApp")
                             .Style(AppStyle("AppTitle")!),
                            new Label().Column(2)
                             .Text("C#")
                             .Style(AppStyle("Title")!),
                        },
                }.CenterVertical()
                 .Margins(20),
                Content = new SearchBar()
                {
                    MaximumWidthRequest = 300,
                    Placeholder = "Search",
                }.FillHorizontal()
                 .CenterVertical()
                 .BackgroundColor(AppColor("White")),
                TrailingContent = new ImageButton()
                {
                    Background = new SolidColorBrush(Transparent),
                    BorderWidth = 0d,
                    Source = new FontImageSource()
                    {
                        FontFamily = "FAS",
                        Glyph = "\xF013",
                        Size = 18,
                    },
                }.Size(36),
            }.Height(48)
             .BackgroundColor(AppColor("Primary"));
        }
    }
}
