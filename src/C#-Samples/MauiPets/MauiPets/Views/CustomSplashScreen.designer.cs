namespace MAUIPETS.Views
{
    public partial class CustomSplashScreen : ContentPage
    {
        private void InitializeComponent()
        {
            Title = "";
            BackgroundColor = AppResource<Color>("Primary");
            Content = new VerticalStackLayout()
            {
                Children =
                {
                    new Image()
                    {
                        Aspect = Aspect.AspectFit,
                        Source = "pets.png",
                    }.Width(200).Start().CenterVertical().Assign(out pets),
                    new ActivityIndicator()
                    {
                        IsRunning = true,
                        Color = White,
                    },
                    new Label()
                    {
                        Text = "Loading information...",
                        TextColor = White,
                    }.Center(),
                }
            };
        }

        #region Variables
        private Image pets;
        #endregion
    }
}

