using Microsoft.Maui.Controls.Shapes;

namespace EcommerceMAUI.Views
{
    public partial class AllProduct : ContentPage
    {
        private void InitializeComponent()
        {
            allProduct = this;
            Shell.SetBackgroundColor(this, White);
            Shell.SetForegroundColor(this, Black);
            Shell.SetTitleColor(this, Black);
            BackgroundColor = White;
            Title = "All Product";
            Content = new CollectionView()
            {
                ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical)
                {
                    HorizontalItemSpacing = 12,
                    VerticalItemSpacing = 12,
                },
                ItemTemplate = new DataTemplate(() =>
                {
                    return new StackLayout()
                    {
                        Background = new SolidColorBrush(White),
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        GestureRecognizers =
                        {
                            new TapGestureRecognizer().BindCommand("BindingContext.TapCommand", source: allProduct, parameterPath: Binding.SelfPath),
                        },
                        Children =
                        {
                            new Border()
                            {
                                StrokeShape = new RoundRectangle()
                                {
                                    CornerRadius = new CornerRadius(6,0,0,6)
                                },
                                Background = new SolidColorBrush(Transparent),
                                StrokeThickness = 1,
                                Content = new Image()
                                {
                                    Aspect = Aspect.AspectFit,
                                }.Height(240).Width(165).Bind("ImageUrl"),
                            },
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    {
                                        TextColor = Black,
                                    }.FontSize(16).CenterHorizontal().Top().Bind("Name"),
                                    new Label()
                                    {
                                        TextColor = Color.FromArgb("#929292"),
                                    }.FontSize(12).CenterHorizontal().Top().Bind("BrandName"),
                                    new Label()
                                    {
                                        TextColor = Color.FromArgb("#00C569"),
                                    }.FontSize(16).CenterHorizontal().Top().Bind("Price"),
                                },
                            }.Margins(0,8,0,0),
                        }
                    }.Margin(0);
                }),
            }.Bind("AllProductDataList").Margin(12);
        }

        #region Variables
        private AllProduct allProduct;
        #endregion
    }
}

