namespace MAUIDemo.Views;

public partial class BookmarksPage : ContentPage
{
    public BookmarksPage(INewsService news)
    {
        InitializeComponent();
        this.BindingContext = new BookmarksViewModel(news);
    }
}
