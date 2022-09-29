namespace MAUIDemo.Models
{
    public class Article
    {
        public string Id { get; set; }

        public string Title { get; }

        public string Subtitle { get; }

        public string ImageURL { get; }

        public string Category { get; }

        public string Time { get; }

        public Article(string id, string title, string subtitle, string imageUrl, string category, string time)
        {
            Id = id;
            Title = title;
            Subtitle = subtitle;
            ImageURL = imageUrl;
            Category = category;
            Time = time;
        }
    }
}
