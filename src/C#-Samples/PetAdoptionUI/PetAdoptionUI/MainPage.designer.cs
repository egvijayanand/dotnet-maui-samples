namespace PetAdoptionUI
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            SetDynamicResource(BackgroundColorProperty, "SecondaryColor");
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto,Auto,Auto,Auto,Auto,Auto),
                ColumnDefinitions = Columns.Define(Star,Star,Star),
                Children =
                {
                    new Image()
                    {
                        Source = "pet.png",
                        Aspect = Aspect.Fill,
                    }.Row(0).Column(0).ColumnSpan(3).Height(400),
                    new Frame()
                    {
                        CornerRadius = 40,
                        HasShadow = false,
                        BackgroundColor = Color.FromArgb("#f9f9f9"),
                        Content = new Grid()
                        {
                            RowDefinitions = Rows.Define(Auto,Auto,Auto),
                            ColumnDefinitions = Columns.Define(Auto,Star,Auto),
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            RowSpacing = 10,
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Martha",
                                    FontAttributes = FontAttributes.Bold,
                                    TextColor = Black,
                                }.Row(0).Column(0).FontSize(21),
                                new Image()
                                {
                                    Source = "symbol",
                                    Aspect = Aspect.AspectFit,
                                }.Row(0).Column(2).Width(22).Height(22).End(),
                                new Label()
                                {
                                    Text = "Border collie",
                                    TextColor = Color.FromArgb("#797979"),
                                }.Row(1).Column(0).FontSize(17),
                                new Image()
                                {
                                    Source = "clock",
                                    Aspect = Aspect.AspectFit,
                                }.Row(1).Column(1).Width(22).Height(22).End(),
                                new Label()
                                {
                                    Text = "1 year old",
                                    TextColor = Color.FromArgb("#797979"),
                                }.Row(1).Column(2).FontSize(15).TextEnd(),
                                new Image()
                                {
                                    Source = "location",
                                    Aspect = Aspect.AspectFit,
                                }.Row(2).Column(0).Width(22).Height(22).Start(),
                                new Label()
                                {
                                    TextColor = Color.FromArgb("#acacac"),
                                    TranslationX = 20,
                                    Text = "120 N 4th St, Brooklyn, NY, USA",
                                }.Row(2).Column(0).ColumnSpan(3).FontSize(15).CenterHorizontal().TextCenterVertical(),
                            },
                        }.Padding(20,5).FillHorizontal().CenterVertical(),
                    }.Row(1).Column(0).ColumnSpan(3).Margins(20,-80,20,10).Height(100),
                    new Frame()
                    {
                        BorderColor = White,
                        HasShadow = false,
                        CornerRadius = 35,
                        IsClippedToBounds = true,
                        Content = new Image()
                        {
                            Source = "owner",
                            Aspect = Aspect.AspectFill,
                        },
                    }.Row(2).Column(0).RowSpan(2).Width(70).Height(70).Padding(0).CenterHorizontal(),
                    new Label()
                    {
                        Text = "Harry Jones",
                        TextColor = Black,
                        FontAttributes = FontAttributes.Bold,
                    }.Row(2).Column(1).Margins(0,30,0,0).Start(),
                    new Label()
                    {
                        Text = "24.01.2022",
                        TextColor = Color.FromArgb("#acacac"),
                    }.Row(2).Column(2).Margins(0,30,25,0).FontSize(14).TextEnd(),
                    new Label()
                    {
                        Text = "Owner",
                        TextColor = Color.FromArgb("#acacac"),
                    }.Row(3).Column(1).Start(),
                    new Label()
                    {
                        TextColor = Color.FromArgb("#a5a5a5"),
                        Text = "Hi! Martha has impeccable manners when I fisrt met her, most of which I've since undone. She's also become very 'chatty' with a full range of Scooby Doo noises when she doesn't feel she's getting the attention she deserves.",
                    }.Row(4).Column(0).ColumnSpan(3).Margin(DeviceInfo.Platform.ToString() switch { nameof(DevicePlatform.Android) => new Thickness(35,20,35,15), nameof(DevicePlatform.iOS) => new Thickness(35,20,35,0) }),
                    new Button()
                    {
                        TextColor = Black,
                        Text = "\x2661",
                        BackgroundColor = White,
                        BorderColor = Silver,
                        BorderWidth = 1,
                        CornerRadius = 25,
                    }.Row(5).Column(0).Width(50).Height(50).End(),
                    new Button()
                    {
                        Text = "Adoption",
                        FontAttributes = FontAttributes.Bold,
                        CornerRadius = 22,
                        TextColor = Black,
                        BackgroundColor = Color.FromArgb("#fbce56"),
                    }.Row(5).Column(1).ColumnSpan(2).Margins(20,0,40,0),
                }
            };
        }
    }
}

