using DateCalculator.ViewModels;

namespace DateCalculator.UI.Views
{
    public partial class DatePage : ContentPage
    {
        public DatePage()
        {
            InitializeComponent();
            //ViewModel = new DateViewModel();
            //BindingContext = ViewModel;
            BindingContext = new DateViewModel();
        }

        private void InitializeComponent()
        {
            this.Bindv2(TitleProperty, static (DateViewModel vm) => vm.Title);
            this.Padding(20);
            Resources.Add("InverseBoolConverter", new InvertedBoolConverter());
            Resources.Add("IntToBoolConverter", new IntToBoolConverter());
            Content = new StackLayout()
            {
                Spacing = 30,
                Children =
                {
                    new Picker().Start()
                        .Bindv2(Picker.ItemsSourceProperty, static (DateViewModel vm) => vm.Options)
                        .Bindv2(static (DateViewModel vm) => vm.SelectedOption),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppStyle("Caption"),
                                Text = "From",
                            },
                            new DatePicker()
                            {
                                Behaviors =
                                {
                                    new EventToCommandBehavior()
                                    {
                                        EventName = nameof(DatePicker.DateSelected),
                                    }.BindCommandv2(static (DateViewModel vm) => vm.DateDiffCommand),
                                },
                            }.Bindv2(static (DateViewModel vm) => vm.StartDate),
                        },
                    }.Start(),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppStyle("Caption"),
                                Text = "To",
                            },
                            new DatePicker()
                            {
                                Behaviors =
                                {
                                    new EventToCommandBehavior()
                                    {
                                        EventName = nameof(DatePicker.DateSelected),
                                    }.BindCommandv2(static (DateViewModel vm) => vm.DateDiffCommand),
                                },
                            }.Bindv2(static (DateViewModel vm) => vm.EndDate),
                        },
                    }.Start().Bindv2(IsVisibleProperty, static(DateViewModel vm) => vm.DiffMode),
                    new StackLayout()
                    {
                        Children =
                        {
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                            }.RadioButtonGroupName("modes")
                             .Bindv2(RadioButtonGroup.SelectedValueProperty, static(DateViewModel vm) => vm.SelectedMode)
                             .ItemsSource(["Add", "Subtract"])
                             .ItemTemplate(() => new RadioButton().Bind(RadioButton.ContentProperty, Binding.SelfPath).Bind(RadioButton.ValueProperty, Binding.SelfPath)),
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
                                            new Picker().Bindv2(Picker.ItemsSourceProperty,static(DateViewModel vm) => vm.Range)
                                                .Bindv2(static(DateViewModel vm) => vm.SelectedYear),
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
                                            new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                .Bindv2(static(DateViewModel vm) => vm.SelectedMonth),
                                        },
                                    },
                                    new StackLayout()
                                    {
                                        Children =
                                        {
                                            new Label()
                                            {
                                                Text = "Weeks",
                                            },
                                            new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                .Bindv2(static(DateViewModel vm) => vm.SelectedWeek),
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
                                            new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                .Bindv2(static(DateViewModel vm) => vm.SelectedDay),
                                        },
                                    },
                                },
                            },
                        },
                    }.Start().Bindv2(IsVisibleProperty, static(DateViewModel vm) => vm.DiffModeInverse),
                    new StackLayout()
                    {
                        Children =
                        {
                            new Label()
                            {
                                Style = AppStyle("Caption"),
                            }.Bindv2(static (DateViewModel vm) => vm.ResultCaption),
                            new Label()
                            {
                                Style = AppStyle("BoldText"),
                            }.Bindv2(static(DateViewModel vm) => vm.DiffResult),
                            new Label().Bindv2(static(DateViewModel vm) => vm.DiffInDays),
                        },
                    }.Start(),
                }
            }.Top();
        }

        //public DateViewModel ViewModel { get; private set; }
    }
}
