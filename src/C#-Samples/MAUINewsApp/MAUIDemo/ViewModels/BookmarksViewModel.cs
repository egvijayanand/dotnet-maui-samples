namespace MAUIDemo.ViewModels;

public class BookmarksViewModel
{
    public BookmarksViewModel(INewsService news)
    {
        Articles = news.GetBookmarkedArticles();

        TappedCommand = new Command<Article>((article) =>
        {
            var query = new Dictionary<string, object>()
                {
                    { "article", article }
                };
            Shell.Current.GoToAsync("//bookmarks/article", query);
        });
    }

    public ICollection<Article> Articles { get; set; }

    public Command TappedCommand { get; set; }
}
