namespace EcommerceMAUI.Views
{
    public partial class CartPage : ContentPage
    {
        private void InitializeComponent()
        {
            cartPage = this;
            Shell.SetBackgroundColor(this, White);
            Shell.SetForegroundColor(this, Black);
            Shell.SetTitleColor(this, Black);
            Shell.SetNavBarIsVisible(this, false);
            BackgroundColor = White;
            Title = "CartPage";
            Content = new CollectionView()
            {
                ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Vertical)
                {
                    VerticalItemSpacing = 12,
                },
                ItemTemplate = new DataTemplate(() =>
                {
                    return new SwipeView()
                    {
                        LeftItems = new SwipeItems()
                        {
                            new SwipeItem()
                            {
                                BackgroundColor = Color.FromArgb("#FFC107"),
                                Text = "Favorite",
                            }.Invoke(x => x.Invoked += SwipeItem_Invoked),
                        },
                        RightItems = new SwipeItems()
                        {
                            new SwipeItem()
                            {
                                BackgroundColor = Color.FromArgb("#FF3D00"),
                                Text = "Delete",
                            }.BindCommand("BindingContext.DeleteCommand", source: cartPage, parameterPath: Binding.SelfPath),
                        },
                        Content = new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 16,
                            Children =
                            {
                                new Image()
                                {
                                    Aspect = Aspect.AspectFit,
                                }.Height(120).Width(120).Bind("ImageUrl"),
                                new StackLayout()
                                {
                                    Spacing = 6,
                                    Children =
                                    {
                                        new Label()
                                        {
                                            HorizontalOptions = LayoutOptions.StartAndExpand,
                                            TextColor = Black,
                                        }.FontSize(16).Bind("Name"),
                                        new StackLayout()
                                        {
                                            Orientation = StackOrientation.Horizontal,
                                            Children =
                                            {
                                                new Label()
                                                {
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    TextColor = Black,
                                                    FontAttributes = FontAttributes.Bold,
                                                }.FontSize(16).Bind("Value", source: _stepper, stringFormat: "QTY: {0}"),
                                                new Label()
                                                {
                                                    HorizontalOptions = LayoutOptions.StartAndExpand,
                                                    TextColor = Color.FromArgb("#00C569"),
                                                }.FontSize(16).Bind("Price"),
                                            },
                                        },
                                        new Stepper()
                                        {
                                            Maximum = 10,
                                            Increment = 1,
                                        }.CenterHorizontal().Bind(Stepper.MinimumProperty, "Qty").Assign(out _stepper).Invoke(x => x.ValueChanged += Stepper_ValueChanged),
                                    },
                                },
                            },
                        },
                    };
                }),
            }.Bind("AllProductDataList").Margin(0,12);
        }

        #region Variables
        private CartPage cartPage;
        private Stepper _stepper;
        #endregion
    }
}

