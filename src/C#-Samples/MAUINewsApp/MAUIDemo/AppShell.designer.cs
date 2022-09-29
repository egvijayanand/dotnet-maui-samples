namespace MAUIDemo
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled;
            Items.Add(new TabBar()
            {
                Items =
                {
                    new Tab()
                    {
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(HomePage)),
                                Route = "home",
                            },
                        },
                    }.Assign(out HomeTab),
                    new Tab()
                    {
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(SectionsPage)),
                                Route = "sections",
                            },
                        },
                    }.Assign(out SectionsTab),
                    new Tab()
                    {
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(BookmarksPage)),
                                Route = "bookmarks",
                            },
                        },
                    }.Assign(out BookmarksTab),
                    new Tab()
                    {
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(ProfilePage)),
                                Route = "profile",
                            },
                        },
                    }.Assign(out ProfileTab),
                }
            });
        }

        #region Variables
        private Tab HomeTab;
        private Tab SectionsTab;
        private Tab BookmarksTab;
        private Tab ProfileTab;
        #endregion
    }
}
