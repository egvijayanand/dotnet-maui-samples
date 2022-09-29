using MAUIDemo.Views;

namespace MAUIDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("article", typeof(ArticlePage));

        HomeTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.home.png", this.GetType().Assembly);
        SectionsTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.categories.png", this.GetType().Assembly);
        BookmarksTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.bookmarks.png", this.GetType().Assembly);
        ProfileTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.profile.png", this.GetType().Assembly);
    }
}
