namespace MauiBMICalculator.Views;

public partial class Step2Page : ContentPage
{
    Step2PageViewModel viewModel;

    public Step2Page(string selectedGender)
    {
        InitializeComponent();

        BindingContext = viewModel = new Step2PageViewModel(Navigation, selectedGender);

        viewModel.HeightWeightChanged += (s, e) => SetDimensions();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        SelectionGrid.SizeChanged += (s, e) => SetDimensions();
        HeightControl.SizeChanged += (s, e) => SetDimensions();
    }

    private void SetDimensions()
    {
        if (viewModel.SelectedHeight == 0 || viewModel.SelectedWeight == 0 || this.Width == -1 || SelectionGrid.Height == -1 || HeightControl.Height == -1)
            return;

        AvatarImage.HeightRequest = SelectionGrid.Height - 15f - (36f * 2) - (HeightControl.Height - 30f) * (HeightControl.Maximum - viewModel.SelectedHeight) / (HeightControl.Maximum - HeightControl.Minimum);
        AvatarImage.WidthRequest = viewModel.SelectedWeight * (this.Width - 160 - 100) / (WeightControl.Maximum - WeightControl.Minimum);
    }
}
