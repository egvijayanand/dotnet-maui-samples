namespace MAUIDemo.Services
{
    public interface INewsService
    {
        public ICollection<string> GetTags();
        public ICollection<Category> GetCategories();
        public ICollection<Article> GetLatestArticles();
        public ICollection<Article> GetRecommendedArticles();
        public ICollection<Article> GetPopularArticles();
        public ICollection<Article> GetBookmarkedArticles();
        public string GetArticleBody(string articleId);
    }
}
