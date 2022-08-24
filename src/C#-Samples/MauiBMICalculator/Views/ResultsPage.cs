namespace MauiBMICalculator.Views;

public partial class ResultsPage : ContentPage
{
    public float ComputedBMI { get; set; }
    public string AvatarImage { get; set; }

    public ResultsPage(string selectedGender, float selectedHeight, float selectedWeight)
    {
        InitializeComponent();

        AvatarImage = $"{selectedGender.ToLower()}.png";

        ComputedBMI = 10000f * selectedWeight / selectedHeight / selectedHeight;

        BindingContext = this;
    }
}
