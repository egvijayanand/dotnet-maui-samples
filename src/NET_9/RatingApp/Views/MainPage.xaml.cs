using CommunityToolkit.Maui.Core;
using System.Reflection;

namespace RatingApp.Views;

public partial class MainPage : ContentPage
{
    readonly NumericValidationBehavior ratingValidation;

    public MainPage()
    {
        InitializeComponent();

        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        lblVersion.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";

        ratingValidation = new NumericValidationBehavior()
        {
            Flags = ValidationFlags.ValidateOnValueChanged,
            MinimumValue = 0.0,
            MaximumDecimalPlaces = 2,
            MaximumValue = 5.0,
            ValidStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.TextColorProperty, Value = Colors.Green }
                }
            },
            InvalidStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.TextColorProperty, Value = Colors.Red }
                }
            }
        };

        txtRating.Behaviors.Add(ratingValidation);

        // For SelectedIndex to work, the Items must be set first
        ddlCount.SelectedIndex = 2;        // 5
        ddlShape.SelectedIndex = 0;        // Star
        ddlSize.SelectedIndex = 2;         // 25
        ddlFillColor.SelectedIndex = 3;    // Yellow
    }

    private void OnShapeChanged(object? sender, EventArgs e)
        => feedback.Shape = (RatingViewShape)((sender as Picker)?.SelectedIndex ?? 0);

    private void OnCountChanged(object? sender, EventArgs e)
    {
        feedback.MaximumRating = Convert.ToInt32((sender as Picker)?.SelectedItem ?? 5);
        ratingValidation.MaximumValue = feedback.MaximumRating;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
        => feedback.ShapeDiameter = Convert.ToDouble((sender as Picker)?.SelectedItem ?? 20);

    private void OnFillColorChanged(object? sender, EventArgs e)
        => feedback.FillColor = Color.Parse((sender as Picker)?.SelectedItem?.ToString() ?? "Yellow");

    private void OnValueChanged(object? sender, TextChangedEventArgs e)
    {
        if (double.TryParse(e.NewTextValue, out var rating) && rating >= 0)
        {
            feedback.Rating = Math.Clamp(rating, 0, feedback.MaximumRating);
        }
        else
        {
            feedback.Rating = 0;
        }

        lblValue.Text = $"Value: {feedback.Rating:N}";
    }

    private void OnRatingChanged(object sender, RatingChangedEventArgs e)
        => lblValue.Text = $"Value: {e.Rating:N}";

    private void OnReadOnlyChanged(object sender, CheckedChangedEventArgs e)
    {
        if (!e.Value)
        {
            txtRating.Text = string.Empty;
        }
    }
}
