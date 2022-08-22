namespace BeautyShopApp.Views
{
    public partial class DetailView : ContentPage
    {
        private void InitializeComponent()
        {
            Content = new StackLayout()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Detail",
                    }.Center(),
                }
            };
        }
    }
}

