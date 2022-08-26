namespace Learn.MauiPaymentUi.Views
{
    public partial class ReceiptView : ContentPage
    {
        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding(nameof(ReceiptViewModel.Title)));
            Content = new ScrollView()
            {
                Content = new VerticalStackLayout()
                {
                    Spacing = 25,
                    Children =
                    {
                        new Label()
                        {
                            Text = "Thank you for shopping!",
                            FontAttributes = FontAttributes.Bold,
                        }.Center(),
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Total Charge: $",
                                    FontAttributes = FontAttributes.Bold,
                                },
                                new Label().Bind(nameof(ReceiptViewModel.TotalPrice)),
                            },
                        }.Center(),
                        new Label()
                        {
                            Text = "Your order is being processed",
                            FontAttributes = FontAttributes.Italic,
                        }.Center(),
                        new Button()
                        {
                            Text = "Finished",
                        }.CenterHorizontal().Bind(nameof(ReceiptViewModel.CmdFinished)),
                    }
                }.Padding(30,0).CenterVertical()
            };
        }
    }
}

