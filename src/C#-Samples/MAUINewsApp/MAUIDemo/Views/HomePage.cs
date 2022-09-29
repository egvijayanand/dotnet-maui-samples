namespace MAUIDemo.Views;

public partial class HomePage : ContentPage
{
    public HomePage(INewsService news)
    {
        ViewModel = new HomeViewModel(news);
        InitializeComponent();
        this.BindingContext = ViewModel;
    }

    public HomeViewModel ViewModel { get; private set; }
}
