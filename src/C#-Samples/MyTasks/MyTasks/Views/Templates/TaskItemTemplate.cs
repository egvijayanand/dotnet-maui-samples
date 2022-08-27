using Task = MyTasks.Models.Task;

namespace MyTasks.Views.Templates
{
    public partial class TaskItemTemplate : ContentView
    {
        public TaskItemTemplate()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                peopleStack.ItemsSource(((Task)BindingContext).People);
            }
        }
    }
}