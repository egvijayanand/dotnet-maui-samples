namespace MyTasks.Views.Cells
{
    public partial class TaskItemViewCell : ViewCell
    {
        private void InitializeComponent()
        {
            View = new TaskItemTemplate()
            {
                Opacity = 0f,
            }.Assign(out TaskItemTemplate);
        }

        #region Variables
        private TaskItemTemplate TaskItemTemplate;
        #endregion
    }
}

