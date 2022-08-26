namespace UIMock;

public partial class OnboardingPage : ContentPage
{
    public OnboardingPage()
    {
        InitializeComponent();
        BindingContext = new OnboardingPageViewModel();
    }
}
