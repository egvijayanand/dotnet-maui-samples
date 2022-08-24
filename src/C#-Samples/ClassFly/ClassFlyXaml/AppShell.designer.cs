using ClassFlyXaml;
using ClassFlyXaml.Pages;

namespace ClassFlyXaml
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            Items.Add(new ShellContent()
            {
                Title = "Choose a course!",
                ContentTemplate = new DataTemplate(typeof(CourseListPage)),
                Route = "CourseListPage",
            });
        }
    }
}

