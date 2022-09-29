namespace MAUIDemo.ViewModels
{
	public class ArticleViewModel
	{
		public ArticleViewModel(INewsService news, Article a)
		{
			Title = a.Title;
			ImageURL = a.ImageURL;
			Body = news.GetArticleBody(a.Id);
			Time = a.Time;
		}

		public string Title { get; set; }

		public string ImageURL { get; set; }

		public string Body { get; set; }

		public string Time { get; set; }
	}
}
