namespace HybridRclApp.WinForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Startup.Init();
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
