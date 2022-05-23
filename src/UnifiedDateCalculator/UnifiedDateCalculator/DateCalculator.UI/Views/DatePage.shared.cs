using DateCalculator.ViewModels;

namespace DateCalculator.UI.Views
{
    public partial class DatePage : ContentPage
    {
        public DatePage()
        {
            InitializeComponent();
            ViewModel = new DateViewModel();
            BindingContext = ViewModel;
        }

        private void InitializeComponent()
        {
            SetBinding(TitleProperty, new Binding(nameof(DateViewModel.Title)));
            this.Padding(20);
            Resources.Add("InverseBoolConverter", new InvertedBoolConverter());
            Resources.Add("IntToBoolConverter", new IntToBoolConverter());
            Content = new StackLayout()
            {
                Spacing = 30,
                Children =
                {
                    new Picker()
                    {
                        Items =
                        {
                            "Difference between dates",
                            "Add or subtract days",
                        },
                    }.Start().Bind(nameof(DateViewModel.Option)),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppResource<Style>("Caption"),
                                Text = "From",
                            },
                            new DatePicker()
                            {
                                Behaviors =
                                {
                                    new EventToCommandBehavior()
                                    {
                                        EventName = "DateSelected",
                                    }.BindCommand(nameof(DateViewModel.DateDiffCommand)),
                                },
                            }.Bind(nameof(DateViewModel.StartDate)),
                        },
                    }.Start(),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppResource<Style>("Caption"),
                                Text = "To",
                            },
                            new DatePicker()
                            {
                                Behaviors =
                                {
                                    new EventToCommandBehavior()
                                    {
                                        EventName = "DateSelected",
                                    }.BindCommand(nameof(DateViewModel.DateDiffCommand)),
                                },
                            }.Bind(nameof(DateViewModel.EndDate)),
                        },
                    }.Start().Bind(IsVisibleProperty, nameof(DateViewModel.DiffMode)),
                    new StackLayout()
                    {
                        Children =
                        {
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                            }.RadioButtonGroupName("modes").Bind(RadioButtonGroup.SelectedValueProperty, nameof(DateViewModel.SelectedMode)).ItemsSource(new string[] { "Add", "Subtract" }).ItemTemplate(new DataTemplate(() =>
                            {
                                return new RadioButton().Bind(RadioButton.ContentProperty, Binding.SelfPath).Bind(RadioButton.ValueProperty, Binding.SelfPath);
                            })),
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 20,
                                Children =
                                {
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                Text = "Years",
                                            },
                                            new Picker().Bind(Picker.ItemsSourceProperty, nameof(DateViewModel.Range)).Bind(nameof(DateViewModel.SelectedYear)),
                                        },
                                    },
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                Text = "Months",
                                            },
                                            new Picker().Bind(Picker.ItemsSourceProperty, nameof(DateViewModel.Range)).Bind(nameof(DateViewModel.SelectedMonth)),
                                        },
                                    },
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                Text = "Days",
                                            },
                                            new Picker().Bind(Picker.ItemsSourceProperty, nameof(DateViewModel.Range)).Bind(nameof(DateViewModel.SelectedDay)),
                                        },
                                    },
                                },
                            },
                        },
                    }.Start().Bind(IsVisibleProperty, nameof(DateViewModel.DiffMode), converter: (IValueConverter)Resources["InverseBoolConverter"]),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppResource<Style>("Caption"),
                            }.Bind(nameof(DateViewModel.ResultCaption)),
                            new Label()
                            {
                                Style = AppResource<Style>("BoldText"),
                            }.Bind(nameof(DateViewModel.DiffResult)),
                            new Label().Bind(nameof(DateViewModel.DiffInDays)),
                        },
                    }.Start(),
                }
            }.Top();
        }

        public DateViewModel ViewModel { get; private set; }
    }
}
