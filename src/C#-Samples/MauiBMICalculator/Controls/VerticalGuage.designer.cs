namespace MauiBMICalculator.Controls
{
    public partial class VerticalGuage : ContentView
    {
        private void InitializeComponent()
        {
            Content = new SKCanvasView()
            {
                EnableTouchEvents = true,
            }.Assign(out guageCanvas).Invoke(x => x.PaintSurface += OnPaintSurface).Invoke(x => x.Touch += guageCanvas_Touch);
        }

        #region Variables
        private SKCanvasView guageCanvas;
        #endregion
    }
}

