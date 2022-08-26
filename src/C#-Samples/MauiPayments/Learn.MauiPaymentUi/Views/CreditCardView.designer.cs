namespace Learn.MauiPaymentUi.Views
{
    public partial class CreditCardView : StackLayout
    {
        private void InitializeComponent()
        {
            BackgroundColor = AppResource<Color>("Primary");
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.Start;
            Children.Add(new Frame()
            {
                //Visual = VisualMarker.Material,
                Content = new Grid()
                {
                    ColumnSpacing = 30,
                    RowSpacing = 0,
                    RowDefinitions = Rows.Define(Auto,Auto,40,Auto,40),
                    ColumnDefinitions = Columns.Define(Auto,Star),
                    Children =
                    {
                        new Image()
                        {
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                        }.Height(40).Row(0).Column(1).Bind(nameof(PaymentViewModel.CardNumber), converter: (IValueConverter)AppResource("CardLightConverter")),
                        new Label()
                        {
                            Text = "Card Number",
                            LineBreakMode = LineBreakMode.TailTruncation,
                            TextColor = AppResource<Color>("Accent"),
                        }.FontSize(12).Row(1).Column(0).ColumnSpan(2),
                        new Label()
                        {
                            TextColor = AppResource<Color>("Secondary"),
                        }.FontSize(20).Row(2).Column(0).ColumnSpan(2).Bind(nameof(PaymentViewModel.CardNumber)),
                        new Label()
                        {
                            Text = "Expiration",
                            TextColor = AppResource<Color>("Accent"),
                        }.Margins(0,20,0,0).FontSize(12).Row(3).Column(0),
                        new Label()
                        {
                            TextColor = AppResource<Color>("Secondary"),
                        }.FontSize(20).Row(4).Column(0).Bind(nameof(PaymentViewModel.CardExpirationDate)),
                        new Label()
                        {
                            Text = "CVV",
                            TextColor = AppResource<Color>("Accent"),
                        }.Margins(0,20,0,0).FontSize(12).Row(3).Column(1),
                        new Label()
                        {
                            TextColor = AppResource<Color>("Secondary"),
                        }.FontSize(20).Row(4).Column(1).Bind(nameof(PaymentViewModel.MaskedCvv)),
                    },
                },
            }.Margins(40,10,40,30).Padding(20).Bind(MauiFrame.BackgroundColorProperty, nameof(PaymentViewModel.CardNumber), converter: (IValueConverter)AppResource("CardColorConverter")));
        }
    }
}

