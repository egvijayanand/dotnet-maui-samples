namespace MyTasks.Controls
{
    public partial class FilterMenu : ContentView
    {
        private void InitializeComponent()
        {
            Content = new Grid()
            {
                Children =
                {
                    new Image()
                    {
                        Source = "outer_circle.png",
                    }.Width(60).Height(60).Center().Assign(out OuterCircle),
                    new Image()
                    {
                        Opacity = 1f,
                        Source = "menu_circle.png",
                    }.Width(60).Height(60).Center().Assign(out InnerButtonMenu),
                    new Image()
                    {
                        Opacity = 0f,
                        Source = "close_circle.png",
                    }.Width(60).Height(60).Center().Assign(out InnerButtonClose),
                    new Image()
                    {
                        Opacity = 0f,
                        Source = "check.png",
                        Aspect = Aspect.AspectFit,
                    }.Margins(0,-60,0,60).Width(40).Height(40).Center().Assign(out N),
                    new Image()
                    {
                        Opacity = 0f,
                        Source = "poweroff.png",
                        Aspect = Aspect.AspectFit,
                    }.Margins(0,-60,130,0).Width(40).Height(40).Fill().Assign(out NW),
                    new Image()
                    {
                        Opacity = 0f,
                        Source = "time.png",
                        Aspect = Aspect.AspectFit,
                    }.Margins(0,60,130,0).Width(40).Height(40).Center().Assign(out SW),
                    new Image()
                    {
                        Opacity = 0f,
                        Source = "warning.png",
                        Aspect = Aspect.AspectFit,
                    }.Margins(0,60,0,-60).Width(40).Height(40).Center().Assign(out S),
                }
            };
        }

        #region Variables
        private Image OuterCircle;
        private Image InnerButtonMenu;
        private Image InnerButtonClose;
        private Image N;
        private Image NW;
        private Image SW;
        private Image S;
        #endregion
    }
}

