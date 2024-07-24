using DateCalculator.ViewModels;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace DateCalculator.UI.Views
{
    public partial class DatePage : ContentPage
    {
        private Label versionLabel;

        public DatePage()
        {
            InitializeComponent();
            //ViewModel = new DateViewModel();
            //BindingContext = ViewModel;
            BindingContext = new DateViewModel();
            var version = typeof(Application).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
#if MAUI
            versionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
#elif FORMS
            versionLabel.Text = $"Xamarin.Forms ver. {version?[..version.IndexOf('+')]}";
#else
            versionLabel.Text = string.Empty;
#endif
        }

        [MemberNotNull(nameof(versionLabel))]
        private void InitializeComponent()
        {
            this.Bindv2(TitleProperty, static (DateViewModel vm) => vm.Title);
            Resources.Add("InverseBoolConverter", new InvertedBoolConverter());
            Resources.Add("IntToBoolConverter", new IntToBoolConverter());
            Content = new Grid()
            {
                RowDefinitions = Rows.Define(Star, 40),
                Children =
                {
                    new StackLayout()
                    {
                        Children =
                        {
                            new Picker()
                             .Start()
                             .Bindv2(Picker.ItemsSourceProperty, static (DateViewModel vm) => vm.Options)
                             .Bindv2(static (DateViewModel vm) => vm.SelectedOption),
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    {
                                        Style = AppStyle("Caption")
                                    }.Text("From"),
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
                                        Style = AppStyle("Caption")
                                    }.Text("To"),
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
                            }.Start()
                             .Bindv2(IsVisibleProperty, static(DateViewModel vm) => vm.DiffMode),
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
                                     .ItemTemplate(() => new RadioButton().Bind(RadioButton.ContentProperty).Bind(RadioButton.ValueProperty)),
                                    new StackLayout()
                                    {
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            new StackLayout()
                                            {
                                                Children =
                                                {
                                                    new Label().Text("Years"),
                                                    new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                        .Bindv2(static(DateViewModel vm) => vm.SelectedYear),
                                                },
                                            },
                                            new StackLayout()
                                            {
                                                Children =
                                                {
                                                    new Label().Text("Months"),
                                                    new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                        .Bindv2(static(DateViewModel vm) => vm.SelectedMonth),
                                                },
                                            },
                                            new StackLayout()
                                            {
                                                Children =
                                                {
                                                    new Label().Text("Weeks"),
                                                    new Picker().Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                        .Bindv2(static(DateViewModel vm) => vm.SelectedWeek),
                                                },
                                            },
                                            new StackLayout()
                                            {
                                                Children =
                                                {
                                                    new Label().Text("Days"),
                                                    new Picker()
                                                     .Bindv2(Picker.ItemsSourceProperty, static(DateViewModel vm) => vm.Range)
                                                     .Bindv2(static(DateViewModel vm) => vm.SelectedDay),
                                                },
                                            },
                                        },
                                    }.Spacing(20),
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
                    }.Row(0)
                     .Top()
                     .Spacing(30)
                     .Padding(20),
                    new Grid()
                    {
                        Style = AppStyle("Footer"),
                        Children =
                        {
                            new Label().Center()
                             .TextColor(AppColor("White"))
                             .Assign(out versionLabel),
                        },
                    }.Row(1)
                }
            };
        }

        //public DateViewModel ViewModel { get; private set; }
    }
}
