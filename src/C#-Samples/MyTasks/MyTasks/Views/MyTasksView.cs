using MyTasks.ViewModels;

namespace MyTasks.Views
{
    public partial class MyTasksView : ContentPage
    {
        public MyTasksView()
        {
            InitializeComponent();

            BindingContext = new MyTasksViewModel();
        }
    }
}
