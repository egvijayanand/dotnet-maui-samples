using EcommerceMAUI.Views;

namespace EcommerceMAUI
{
    public partial class AppShell : Shell
    {
        private void InitializeComponent()
        {
            Shell.SetTabBarBackgroundColor(this, White);
            Shell.SetTabBarTitleColor(this, Green);
            Shell.SetTabBarUnselectedColor(this, Black);
            FlyoutBehavior = FlyoutBehavior.Disabled;
            Items.Add(new TabBar()
            {
                Items =
                {
                    new Tab()
                    {
                        Title = "Explore",
                        Icon = new FontImageSource()
                        {
                            FontFamily = "icon",
                            Glyph = "\xF56E",
                        },
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(HomePage)),
                            },
                        },
                    },
                    new Tab()
                    {
                        Title = "Cart",
                        Icon = new FontImageSource()
                        {
                            FontFamily = "icon",
                            Glyph = "\xF110",
                        },
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(CartPage)),
                            },
                        },
                    },
                    new Tab()
                    {
                        Title = "Account",
                        Icon = new FontImageSource()
                        {
                            FontFamily = "icon",
                            Glyph = "\xF004",
                        },
                        Items =
                        {
                            new ShellContent()
                            {
                                ContentTemplate = new DataTemplate(typeof(Profile)),
                            },
                        },
                    },
                }
            });
        }
    }
}

