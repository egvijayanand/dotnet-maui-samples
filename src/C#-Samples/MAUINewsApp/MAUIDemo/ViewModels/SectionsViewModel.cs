namespace MAUIDemo.ViewModels
{
    public class SectionsViewModel
    {
        public SectionsViewModel(INewsService news)
        {
            Sections = news.GetCategories();
        }

        public ICollection<Category> Sections { get; set; }
    }
}
