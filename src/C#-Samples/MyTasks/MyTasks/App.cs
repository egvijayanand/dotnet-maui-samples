namespace MyTasks;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MyTasksView();
    }
}
