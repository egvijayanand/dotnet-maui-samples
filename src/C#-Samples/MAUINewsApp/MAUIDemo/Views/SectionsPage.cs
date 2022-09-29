namespace MAUIDemo.Views;

public partial class SectionsPage : ContentPage
{
    public SectionsPage(INewsService news)
    {
        ViewModel = new SectionsViewModel(news);
        InitializeComponent();

        // Dynamic grid definition based on the Sections data
        // Two column layout
        int rows = (ViewModel.Sections.Count / 2) + (ViewModel.Sections.Count % 2);

        for (int i = 0; i < rows; i++)
        {
            sections.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        }

        BindingContext = ViewModel;
    }

    public SectionsViewModel ViewModel { get; private set; }
}
