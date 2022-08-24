using SkiaSharp.Views.Maui;

namespace MauiBMICalculator.Controls;

public partial class VerticalGuage : ContentView
{
    private float density;
    private float regularStrokeWidth = 3;
    private float majorStrokeWidth = 4;
    private float minorStrokeWidth = 2;
    private float indicatorStrokeWidth = 6;
    private float guageWidth = 60;

    private SKPaint regularStrokePaint, minorStrokePaint, majorStrokePaint, indicatorStrokePaint, fillPaint;
    private SKColor strokeColor = new SKColor(117, 117, 117, 230);
    private SKColor fillColor = new SKColor(117, 117, 117, 50);

    public static BindableProperty MaximumProperty = BindableProperty.Create("Maximum", typeof(float), typeof(VerticalGuage), 100f, BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty MinimumProperty = BindableProperty.Create("Minimum", typeof(float), typeof(VerticalGuage), 0f, BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty StepProperty = BindableProperty.Create("Step", typeof(float), typeof(VerticalGuage), 20f, BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty MinorTicksProperty = BindableProperty.Create("MinorTicks", typeof(float), typeof(VerticalGuage), 20f, BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty IndicatorValueProperty = BindableProperty.Create("IndicatorValue", typeof(float), typeof(VerticalGuage), 20f, BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty IndicatorValueUnitProperty = BindableProperty.Create("IndicatorValueUnit", typeof(string), typeof(VerticalGuage), "", BindingMode.OneWay, null, InvalidateGauge);

    public static BindableProperty IndicatorDirectionProperty = BindableProperty.Create("IndicatorDirection", typeof(string), typeof(VerticalGuage), "Right", BindingMode.OneWay, null, InvalidateGauge);

    public float Maximum
    {
        get => (float)this.GetValue(MaximumProperty);
        set => this.SetValue(MaximumProperty, value);
    }

    public float Minimum
    {
        get => (float)this.GetValue(MinimumProperty);
        set => this.SetValue(MinimumProperty, value);
    }

    public float Step
    {
        get => (float)this.GetValue(StepProperty);
        set => this.SetValue(StepProperty, value);
    }

    public float MinorTicks
    {
        get => (float)this.GetValue(MinorTicksProperty);
        set => this.SetValue(MinorTicksProperty, value);
    }

    public float IndicatorValue
    {
        get => (float)this.GetValue(IndicatorValueProperty);
        set => this.SetValue(IndicatorValueProperty, value);
    }

    public string IndicatorValueUnit
    {
        get => (string)this.GetValue(IndicatorValueUnitProperty);
        set => this.SetValue(IndicatorValueUnitProperty, value);
    }

    public string IndicatorDirection
    {
        get => (string)this.GetValue(IndicatorDirectionProperty);
        set => this.SetValue(IndicatorDirectionProperty, value);
    }

    private static void InvalidateGauge(BindableObject bindable, object oldValue, object newValue) =>
        (bindable as VerticalGuage).guageCanvas.InvalidateSurface();


    public VerticalGuage()
    {
        InitializeComponent();

        regularStrokePaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = regularStrokeWidth,
            Color = strokeColor,
            IsAntialias = true
        };

        minorStrokePaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = minorStrokeWidth,
            Color = strokeColor,
            IsAntialias = true
        };

        majorStrokePaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = majorStrokeWidth,
            Color = strokeColor,
            IsAntialias = true
        };

        indicatorStrokePaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = indicatorStrokeWidth,
            Color = strokeColor,
            IsAntialias = true
        };

        fillPaint = new SKPaint
        {
            Style = SKPaintStyle.Fill,
            Color = fillColor,
            IsAntialias = true
        };
    }

    void OnPaintSurface(System.Object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
    {
        SKSurface surface = e.Surface;
        SKCanvas canvas = surface.Canvas;
        SKImageInfo info = e.Info;

        //Compute the Screen Density
        var width = info.Width;
        var height = info.Height;
        density = width / (float)this.Width;

        // clear the surface
        canvas.Clear(SKColors.Transparent);

        //Draw the guage container
        DrawGuageOutLine(canvas, width, height);

        //Draw Axis
        DrawGuageAxis(canvas, width, height);

        //Draw Value Indicator
        DrawValueIndicator(canvas, width, height);
    }

    private void DrawGuageOutLine(SKCanvas canvas, int width, int height)
    {
        float verticalMargin = guageWidth / 2 + regularStrokeWidth / 2;

        using (SKPath containerPath = new SKPath())
        {
            switch (IndicatorDirection)
            {
                case "Right":
                    containerPath.MoveTo(regularStrokeWidth / 2, verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, guageWidth + regularStrokeWidth / 2, verticalMargin);
                    containerPath.LineTo(guageWidth + regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.Close();
                    break;
                case "Left":
                    containerPath.MoveTo(width - guageWidth - regularStrokeWidth / 2, verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, width - regularStrokeWidth / 2, verticalMargin);
                    containerPath.LineTo(width - regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, width - guageWidth - regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.Close();
                    break;
            }

            canvas.DrawPath(containerPath, regularStrokePaint);
        }
    }

    private void DrawGuageAxis(SKCanvas canvas, int width, int height)
    {
        var numMajorTicks = (Maximum - Minimum) / Step;
        var majorDistance = (height - guageWidth * 2) / numMajorTicks;

        var numMinorTicks = MinorTicks * numMajorTicks;
        var minorDistance = (height - guageWidth * 2) / numMinorTicks;

        for (int i = 0; i <= numMajorTicks; i++)
        {
            var start = new SKPoint(IndicatorDirection == "Right" ? guageWidth : width - guageWidth, i * majorDistance + guageWidth);
            var end = new SKPoint(IndicatorDirection == "Right" ? guageWidth / 2.5f : width - guageWidth / 2.5f, i * majorDistance + guageWidth);

            canvas.DrawLine(start, end, majorStrokePaint);
        }

        for (int i = 0; i <= numMinorTicks; i++)
        {
            var start = new SKPoint(IndicatorDirection == "Right" ? guageWidth : width - guageWidth, i * minorDistance + guageWidth);
            var end = new SKPoint(IndicatorDirection == "Right" ? guageWidth - guageWidth / 4 : width - guageWidth + guageWidth / 4, i * minorDistance + guageWidth);

            canvas.DrawLine(start, end, minorStrokePaint);
        }
    }

    private void DrawValueIndicator(SKCanvas canvas, int width, int height)
    {
        if (IndicatorValue < Minimum || IndicatorValue > Maximum)
            return;

        float indicatorPosition = (height - guageWidth * 2) * (1f - (IndicatorValue - Minimum) / (Maximum - Minimum)) + guageWidth;
        float verticalMargin = guageWidth / 2 + regularStrokeWidth / 2;

        //Draw Indicator Line
        var start = new SKPoint(IndicatorDirection == "Right" ? guageWidth + 10 : width - guageWidth - 10, indicatorPosition);
        var end = new SKPoint(IndicatorDirection == "Right" ? guageWidth + 40 : width - guageWidth - 40, indicatorPosition);

        canvas.DrawLine(start, end, indicatorStrokePaint);

        //Draw Value Label
        using (var textPaint = new SKPaint())
        {
            textPaint.TextSize = (DeviceInfo.Platform == DevicePlatform.Android) ? 40 : 32;
            textPaint.IsAntialias = true;
            textPaint.Color = strokeColor;
            textPaint.IsStroke = false;

            var indicatorText = IndicatorValue.ToString("0.0") + (!String.IsNullOrEmpty(IndicatorValueUnit) ? " " + IndicatorValueUnit : "");

            if (IndicatorDirection == "Right")
                canvas.DrawText(indicatorText, guageWidth + 40 + 10, indicatorPosition + 10, textPaint);
            else
            {
                float textWidth = textPaint.MeasureText(indicatorText);

                canvas.DrawText(indicatorText, width - guageWidth - 40 - 10 - textWidth, indicatorPosition + 10, textPaint);
            }
        }

        //Fill the guage
        using (SKPath containerPath = new SKPath())
        {
            switch (IndicatorDirection)
            {
                case "Right":
                    containerPath.MoveTo(regularStrokeWidth / 2, indicatorPosition);
                    containerPath.LineTo(guageWidth + regularStrokeWidth / 2, indicatorPosition);
                    containerPath.LineTo(guageWidth + regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.Close();
                    break;
                case "Left":
                    containerPath.MoveTo(width - guageWidth - regularStrokeWidth / 2, indicatorPosition);
                    containerPath.LineTo(width - regularStrokeWidth / 2, indicatorPosition);
                    containerPath.LineTo(width - regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.ArcTo(guageWidth / 2, guageWidth / 2, 0, SKPathArcSize.Large, SKPathDirection.Clockwise, width - guageWidth - regularStrokeWidth / 2, height - verticalMargin);
                    containerPath.Close();
                    break;
            }

            canvas.DrawPath(containerPath, fillPaint);
        }
    }

    void guageCanvas_Touch(System.Object sender, SkiaSharp.Views.Maui.SKTouchEventArgs e)
    {
        if (e.ActionType == SKTouchAction.Pressed || e.ActionType == SKTouchAction.Released || e.ActionType == SKTouchAction.Moved)
        {
            var actualHeight = Height * density;
            var y = e.Location.Y;

            if (y < guageWidth || y > actualHeight - guageWidth)
                return;

            IndicatorValue = Convert.ToSingle(Minimum + (actualHeight - y - guageWidth) * (Maximum - Minimum) / (actualHeight - 2 * guageWidth));
        }

        e.Handled = true;
    }
}
