using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DateCalculator.Extensions;
using DateCalculator.Helpers;
using DateCalculator.Models;
using VijayAnand.Toolkit.ObjectModel;

namespace DateCalculator.ViewModels
{
    public partial class DateViewModel : BaseViewModel
    {
        [ObservableProperty]
        private DateTime startDate = DateTime.Today;

        [ObservableProperty]
        private DateTime endDate = DateTime.Today;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DiffModeInverse))]
        private bool diffMode = true;

        [ObservableProperty]
        private int selectedYear;

        [ObservableProperty]
        private int selectedMonth;

        [ObservableProperty]
        private int selectedDay;

        [ObservableProperty]
        private string resultCaption = "Difference";

        [ObservableProperty]
        private string diffResult = string.Empty;

        [ObservableProperty]
        private string diffInDays = string.Empty;

        [ObservableProperty]
        private int selectedOption;

        [ObservableProperty]
        private string? selectedMode;

        //private readonly List<int> range = new();

        public DateViewModel() : base("Date Calculation") => FindTheDate();

		public IReadOnlyList<string> Options { get; } = ["Difference between dates", "Add or subtract days"];

		public IReadOnlyList<int> Range { get; } = Enumerable.Range(0, 1000).ToList();

        public bool DiffModeInverse => !DiffMode;

        // While using classic MVVM
        /*
        public DateTime StartDate
        {
            get => startDate;
            set => SetProperty(ref startDate, value);
        }

        public DateTime EndDate
        {
            get => endDate;
            set => SetProperty(ref endDate, value);
        }

        public int Option
        {
            get => option;
            set => SetProperty(ref option, value, onChanged: () => DiffMode = Option == 0);
        }
        
        public bool DiffMode
        {
            get => diffMode;
            set => SetProperty(ref diffMode, value, onChanged: () =>
            {
                if (value)
                {
                    ResultCaption = "Difference";
                    SelectedMode = string.Empty;
                }
                else
                {
                    ResultCaption = "Date";
                    SelectedMode = "Add";
                }
            });
        }

        public string SelectedMode
        {
            get => selectedMode;
            set => SetProperty(ref selectedMode, value, onChanged: FindTheDate);
        }
        
        public int SelectedYear
        {
            get => selectedYear;
            set => SetProperty(ref selectedYear, value, onChanged: FindTheDate);
        }

        public int SelectedMonth
        {
            get => selectedMonth;
            set => SetProperty(ref selectedMonth, value, onChanged: FindTheDate);
        }

        public int SelectedDay
        {
            get => selectedDay;
            set => SetProperty(ref selectedDay, value, onChanged: FindTheDate);
        }
        public string ResultCaption
        {
            get => resultCaption;
            set => SetProperty(ref resultCaption, value);
        }

        public string DiffResult
        {
            get => diffResult;
            set => SetProperty(ref diffResult, value);
        }

        public string DiffInDays
        {
            get => diffInDays;
            set => SetProperty(ref diffInDays, value);
        }

        public ICommand DiffCommand => new Command(FindTheDate);
        */

        partial void OnDiffModeChanged(bool value)
        {
            if (value)
            {
                ResultCaption = "Difference";
            }
            else
            {
                ResultCaption = "Date";

                if (SelectedMode is null)
                {
                    SelectedMode = "Add";
                }
            }

            FindTheDate();
        }

        partial void OnSelectedOptionChanged(int value) => DiffMode = value == 0;

        partial void OnStartDateChanged(DateTime value) => FindTheDate();

        partial void OnEndDateChanged(DateTime value) => FindTheDate();

        partial void OnSelectedModeChanged(string? value) => FindTheDate();

        partial void OnSelectedYearChanged(int value) => FindTheDate();

        partial void OnSelectedMonthChanged(int value) => FindTheDate();

        partial void OnSelectedDayChanged(int value) => FindTheDate();

        [RelayCommand]
        private void DateDiff() => FindTheDate();

        private void FindTheDate()
        {
            if (DiffMode)
            {
                var dtStart = StartDate;
                var dtEnd = EndDate;

                // If the startDate is later than the endDate, then swap their values
                if (StartDate > EndDate)
                {
                    dtStart = EndDate;
                    dtEnd = StartDate;
                }

                DiffResult = Utility.DateDiff(dtStart, dtEnd);
                DiffInDays = ((int)(dtEnd - dtStart).TotalDays).InWords(TimeUnit.Day);
            }
            else
            {
                var factor = SelectedMode == "Subtract" ? -1 : 1;
                DiffResult = StartDate.AddYears(SelectedYear * factor)
                                      .AddMonths(SelectedMonth * factor)
                                      .AddDays(SelectedDay * factor)
                                      .ToLongDateString();
                DiffInDays = string.Empty;
            }
        }
    }
}
