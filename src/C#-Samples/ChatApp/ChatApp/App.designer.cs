namespace ChatApp
{
    public partial class App : Application
    {
        private void InitializeComponent()
        {
            windows.Application.SetImageDirectory(this, "Assets");
            Resources.Add("PrimaryColor", Color.FromArgb("#5B61B9"));
            Resources.Add("SecondaryColor", White);
        }
    }
}

