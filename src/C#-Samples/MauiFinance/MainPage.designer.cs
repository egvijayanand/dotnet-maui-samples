namespace MauiFinance
{
    public partial class MainPage : ContentPage
    {
        private void InitializeComponent()
        {
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Auto,Auto,Auto,Star,Auto),
                ColumnDefinitions = Columns.Define(Star,Star,Star),
                RowSpacing = 15,
                Children =
                {
                    new Border()
                    {
                        StrokeThickness = 0,
                        StrokeShape = new RoundRectangle()
                        {
                            CornerRadius = new CornerRadius(25)
                        },
                        Shadow = new Shadow()
                        {
                            Radius = 60,
                            Opacity = 0.2f,
                        },
                        Content = new Grid()
                        {
                            RowDefinitions = Rows.Define(55,Auto,Auto,Auto,Auto,50),
                            Children =
                            {
                                new Image()
                                {
                                    Source = "sort",
                                }.Height(24).Margins(15,0,0,0).Start(),
                                new Image()
                                {
                                    Source = "more",
                                }.Height(24).Margins(0,0,15,0).End(),
                                new Border()
                                {
                                    StrokeThickness = 0,
                                    StrokeShape = new RoundRectangle()
                                    {
                                        CornerRadius = new CornerRadius(50)
                                    },
                                    Content = new Image()
                                    {
                                        Source = "cemahseri",
                                        Aspect = Aspect.AspectFill,
                                    }.Width(100).Height(100),
                                }.Row(1).CenterHorizontal(),
                                new Label()
                                {
                                    Text = "cemahseri",
                                    FontAttributes = FontAttributes.Bold,
                                    LineBreakMode = LineBreakMode.NoWrap,
                                    TextColor = AppResource<Color>("Primary"),
                                }.Row(2).FontSize(22).Paddings(0,15,0,0).TextCenterHorizontal(),
                                new Label()
                                {
                                    Text = "Back-End Developer",
                                    TextColor = Black,
                                }.Row(3).FontSize(14).Paddings(0,5,0,0).TextCenterHorizontal(),
                                new Grid()
                                {
                                    RowDefinitions = Rows.Define(Auto,Star),
                                    ColumnDefinitions = Columns.Define(Auto,Star,Auto,Star,Auto),
                                    RowSpacing = 10,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            Text = "$8900",
                                            FontAttributes = FontAttributes.Bold,
                                            TextColor = AppResource<Color>("Primary"),
                                        }.Row(0).Column(0).TextCenterHorizontal(),
                                        new Label()
                                        {
                                            Text = "Income",
                                        }.Row(1).Column(0).FontSize(13).TextCenterHorizontal(),
                                        new Rectangle()
                                        {
                                            StrokeThickness = 0,
                                            Fill = Gray,
                                        }.RowSpan(2).Column(1).Width(1).FillVertical(),
                                        new Label()
                                        {
                                            Text = "$5500",
                                            FontAttributes = FontAttributes.Bold,
                                            TextColor = AppResource<Color>("Primary"),
                                        }.Row(0).Column(2).TextCenterHorizontal(),
                                        new Label()
                                        {
                                            Text = "Expenses",
                                        }.Row(1).Column(2).FontSize(13).TextCenterHorizontal(),
                                        new Rectangle()
                                        {
                                            StrokeThickness = 0,
                                            Fill = Gray,
                                        }.RowSpan(2).Column(3).Width(1).FillVertical(),
                                        new Label()
                                        {
                                            Text = "$890",
                                            FontAttributes = FontAttributes.Bold,
                                            TextColor = AppResource<Color>("Primary"),
                                        }.Row(0).Column(4).TextCenterHorizontal(),
                                        new Label()
                                        {
                                            Text = "Loan",
                                        }.Row(1).Column(4).FontSize(13).TextCenterHorizontal(),
                                    },
                                }.Row(4).Paddings(50,45,50,0),
                            },
                        }.CenterVertical(),
                    }.ColumnSpan(3),
                    new HorizontalStackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Text = "Overview",
                                FontAttributes = FontAttributes.Bold,
                                TextColor = AppResource<Color>("Primary"),
                            }.FontSize(22).CenterVertical(),
                            new Border()
                            {
                                StrokeThickness = 0,
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(20)
                                },
                                BackgroundColor = Transparent,
                                Content = new Image()
                                {
                                    Source = "notifications",
                                }.Height(24),
                            }.Padding(10).CenterHorizontal(),
                        },
                    }.Row(1),
                    new Label()
                    {
                        Text = "Aug 9, 2022",
                        FontAttributes = FontAttributes.Bold,
                        TextColor = AppResource<Color>("Primary"),
                    }.Row(1).ColumnSpan(3).FontSize(14).End().CenterVertical().TextEnd(),
                    new Grid()
                    {
                        RowDefinitions = Rows.Define(Auto,Auto,Auto),
                        ColumnDefinitions = Columns.Define(Star),
                        RowSpacing = 18,
                        Children =
                        {
                            new Border()
                            {
                                StrokeThickness = 0,
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(25)
                                },
                                Shadow = new Shadow()
                                {
                                    Radius = 60,
                                    Opacity = 0.2f,
                                },
                                Content = new Grid()
                                {
                                    RowDefinitions = Rows.Define(60),
                                    ColumnDefinitions = Columns.Define(60,Auto,Star),
                                    ColumnSpacing = 10,
                                    Children =
                                    {
                                        new Border()
                                        {
                                            StrokeThickness = 0,
                                            StrokeShape = new RoundRectangle()
                                            {
                                                CornerRadius = new CornerRadius(20)
                                            },
                                            BackgroundColor = AppResource<Color>("SeconaryBackground"),
                                            Content = new Image()
                                            {
                                                Source = "arrow_upward",
                                            }.Height(36),
                                        },
                                        new VerticalStackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    Text = "Sent",
                                                    FontAttributes = FontAttributes.Bold,
                                                }.FontSize(16),
                                                new Label()
                                                {
                                                    Text = "Sending Payments to Clients",
                                                }.FontSize(12),
                                            },
                                        }.Column(1).CenterVertical(),
                                        new Label()
                                        {
                                            Text = "$150",
                                            FontAttributes = FontAttributes.Bold,
                                        }.Column(2).CenterVertical().TextEnd(),
                                    },
                                }.Paddings(15,0,15,0).CenterVertical(),
                            }.Row(0).Height(80),
                            new Border()
                            {
                                StrokeThickness = 0,
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(25)
                                },
                                Shadow = new Shadow()
                                {
                                    Radius = 60,
                                    Opacity = 0.2f,
                                },
                                Content = new Grid()
                                {
                                    RowDefinitions = Rows.Define(60),
                                    ColumnDefinitions = Columns.Define(60,Auto,Star),
                                    ColumnSpacing = 10,
                                    Children =
                                    {
                                        new Border()
                                        {
                                            StrokeThickness = 0,
                                            StrokeShape = new RoundRectangle()
                                            {
                                                CornerRadius = new CornerRadius(20)
                                            },
                                            BackgroundColor = AppResource<Color>("SeconaryBackground"),
                                            Content = new Image()
                                            {
                                                Source = "arrow_downward",
                                            }.Height(36),
                                        },
                                        new VerticalStackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    Text = "Receive",
                                                    FontAttributes = FontAttributes.Bold,
                                                }.FontSize(16),
                                                new Label()
                                                {
                                                    Text = "Receiving Salary from company",
                                                }.FontSize(12),
                                            },
                                        }.Column(1).CenterVertical(),
                                        new Label()
                                        {
                                            Text = "$306",
                                            FontAttributes = FontAttributes.Bold,
                                        }.Column(2).CenterVertical().TextEnd(),
                                    },
                                }.Paddings(15,0,15,0).CenterVertical(),
                            }.Row(1).Height(80),
                            new Border()
                            {
                                StrokeThickness = 0,
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(25)
                                },
                                Shadow = new Shadow()
                                {
                                    Radius = 60,
                                    Opacity = 0.2f,
                                },
                                Content = new Grid()
                                {
                                    RowDefinitions = Rows.Define(60),
                                    ColumnDefinitions = Columns.Define(60,Auto,Star),
                                    ColumnSpacing = 10,
                                    Children =
                                    {
                                        new Border()
                                        {
                                            StrokeThickness = 0,
                                            StrokeShape = new RoundRectangle()
                                            {
                                                CornerRadius = new CornerRadius(20)
                                            },
                                            BackgroundColor = AppResource<Color>("SeconaryBackground"),
                                            Content = new Image()
                                            {
                                                Source = "payments",
                                            }.Height(36),
                                        },
                                        new VerticalStackLayout()
                                        {
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    Text = "Loan",
                                                    FontAttributes = FontAttributes.Bold,
                                                }.FontSize(16),
                                                new Label()
                                                {
                                                    Text = "Loan for the Car",
                                                }.FontSize(12),
                                            },
                                        }.Column(1).CenterVertical(),
                                        new Label()
                                        {
                                            Text = "$400",
                                            FontAttributes = FontAttributes.Bold,
                                        }.Column(2).CenterVertical().TextEnd(),
                                    },
                                }.Paddings(15,0,15,0).CenterVertical(),
                            }.Row(2).Height(80),
                        },
                    }.Row(2).ColumnSpan(3).CenterVertical(),
                    new Grid()
                    {
                        RowDefinitions = Rows.Define(Star),
                        ColumnDefinitions = Columns.Define(Star,Star,Star,Star,Star),
                        ColumnSpacing = 50,
                        Children =
                        {
                            new Image()
                            {
                                Source = "home",
                            }.Column(0).Height(30).CenterHorizontal().Top(),
                            new Image()
                            {
                                Source = "credit_card",
                            }.Column(1).Height(30).CenterHorizontal().Top(),
                            new Border()
                            {
                                StrokeThickness = 0,
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(10)
                                },
                                BackgroundColor = AppResource<Color>("Primary"),
                                Content = new Image()
                                {
                                    Source = "add",
                                }.Height(22).Width(22).Center(),
                            }.Column(2).Height(38).Width(42),
                            new Image()
                            {
                                Source = "attach_money",
                            }.Column(3).Height(30).CenterHorizontal().Top(),
                            new Image()
                            {
                                Source = "account",
                            }.Column(4).Height(30).CenterHorizontal().Top(),
                        },
                    }.Row(4).ColumnSpan(3).Paddings(0,0,0,10),
                }
            }.Padding(30,25);
        }
    }
}

