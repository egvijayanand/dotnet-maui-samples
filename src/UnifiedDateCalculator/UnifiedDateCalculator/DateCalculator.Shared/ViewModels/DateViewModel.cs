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
        private DateTime startDate;

        [ObservableProperty]
        private DateTime endDate;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DiffModeInverse))]
        private bool diffMode;

        [ObservableProperty]
        private int selectedYear;

        [ObservableProperty]
        private int selectedMonth;

        [ObservableProperty]
        private int selectedDay;

        [ObservableProperty]
        private string resultCaption = string.Empty;

        [ObservableProperty]
        private string diffResult = string.Empty;

        [ObservableProperty]
        private string diffInDays = string.Empty;

        [ObservableProperty]
        private int option;

        [ObservableProperty]
        private string selectedMode = string.Empty;

        //private readonly List<int> range = new();

        public DateViewModel()
        {
            Title = "Date Calculation";
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
            DiffMode = true;
            SelectedMode = string.Empty;

            Range = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                Range.Add(i);
            }

            FindTheDate();
        }

        public IList<int> Range { get; init; }

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
                SelectedMode = string.Empty;
            }
            else
            {
                ResultCaption = "Date";
                SelectedMode = "Add";
            }
        }

        partial void OnOptionChanged(int value) => DiffMode = value == 0;

        partial void OnStartDateChanged(DateTime value) => FindTheDate();

        partial void OnEndDateChanged(DateTime value) => FindTheDate();

        partial void OnSelectedModeChanged(string value) => FindTheDate();

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
                int factor = 1;

                if (SelectedMode == "Subtract")
                {
                    factor = -1;
                }

                DiffResult = StartDate.AddYears(SelectedYear * factor)
                                      .AddMonths(SelectedMonth * factor)
                                      .AddDays(SelectedDay * factor)
                                      .ToLongDateString();
                DiffInDays = string.Empty;
            }
        }
    }
}
