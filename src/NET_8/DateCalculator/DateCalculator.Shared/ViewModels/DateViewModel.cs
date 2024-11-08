#define FIELDS
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DateCalculator.Extensions;
using DateCalculator.Helpers;
using DateCalculator.Models;
using System.ComponentModel;
using VijayAnand.Toolkit.ObjectModel;

namespace DateCalculator.ViewModels
{
    public partial class DateViewModel : BaseViewModel
    {
#if FIELDS
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StartDate1))]
        //[TypeConverter(typeof(DateTimeOffsetConverter))]
        private DateTimeOffset startDate = DateTime.Today;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(EndDate1))]
        //[TypeConverter(typeof(DateTimeOffsetConverter))]
        private DateTimeOffset endDate = DateTime.Today;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DiffModeInverse))]
        private bool diffMode = true;

        [ObservableProperty]
        private int selectedYear;

        [ObservableProperty]
        private int selectedMonth;

        [ObservableProperty]
        private int selectedWeek;

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

        [ObservableProperty]
        private bool addMode = true;
#else
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StartDate1))]
        //[TypeConverter(typeof(DateTimeOffsetConverter))]
        public partial DateTimeOffset StartDate { get; set; } = DateTime.Today;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(EndDate1))]
        //[TypeConverter(typeof(DateTimeOffsetConverter))]
        public partial DateTimeOffset EndDate { get; set; } = DateTime.Today;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DiffModeInverse))]
        public partial bool DiffMode { get; set; } = true;

        [ObservableProperty]
        public partial int SelectedYear { get; set; }

        [ObservableProperty]
        public partial int SelectedMonth { get; set; }

        [ObservableProperty]
        public partial int SelectedWeek { get; set; }

        [ObservableProperty]
        public partial int SelectedDay { get; set; }

        [ObservableProperty]
        public partial string ResultCaption { get; set; } = "Difference";

        [ObservableProperty]
        public partial string DiffResult { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string DiffInDays { get; set; } = string.Empty;

        [ObservableProperty]
        public partial int SelectedOption { get; set; }

        [ObservableProperty]
        public partial string? SelectedMode { get; set; }

        [ObservableProperty]
        public partial bool AddMode { get; set; } = true;
#endif

        public DateViewModel()
        {
            Title = "Date Calculation";
            FindTheDate();
        }

        public IReadOnlyList<string> Options { get; } = ["Difference between dates", "Add or subtract days"];

        public IReadOnlyList<int> Range { get; } = Enumerable.Range(0, 1000).ToList();

        #region For WinForms
        public DateTime StartDate1
        {
            get => StartDate.Date;
            set => StartDate = value;
        }

        public DateTime EndDate1
        {
            get => EndDate.Date;
            set => EndDate = value;
        }

        public IReadOnlyList<int> YearRange { get; } = Enumerable.Range(0, 1000).ToList();

        public IReadOnlyList<int> MonthRange { get; } = Enumerable.Range(0, 1000).ToList();

        public IReadOnlyList<int> WeekRange { get; } = Enumerable.Range(0, 1000).ToList();

        public IReadOnlyList<int> DayRange { get; } = Enumerable.Range(0, 1000).ToList();
        #endregion

        public bool DiffModeInverse => !DiffMode;

        #region Classic-MVVM
        /*
        public DateTimeOffset StartDate
        {
            get => startDate;
            set => SetProperty(ref startDate, value);
        }

        public DateTimeOffset EndDate
        {
            get => endDate;
            set => SetProperty(ref endDate, value);
        }

        public int SelectedOption
        {
            get => selectedOption;
            set => SetProperty(ref selectedOption, value, onChanged: () => DiffMode = value == 0);
        }

        public bool DiffMode
        {
            get => diffMode;
            set => SetProperty(ref diffMode, value, onChanged: () =>
            {
                if (value)
                {
                    ResultCaption = "Difference";
                    //SelectedMode = string.Empty;
                }
                else
                {
                    ResultCaption = "Date";

                    if (SelectedMode is null)
                    {
                        SelectedMode = "Add";
                    }
                }
            });
        }

        public bool AddMode
        {
            get => addMode;
            set => SetProperty(ref addMode, value, onChanged: FindTheDate);
        }

        public string SelectedMode
        {
            get => selectedMode;
            set => SetProperty(ref selectedMode, value, onChanged: () =>
            {
                AddMode = value == "Add";
                FindTheDate();
            });
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

        public int SelectedWeek
        {
            get => selectedWeek;
            set => SetProperty(ref selectedWeek, value, onChanged: FindTheDate);
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
        #endregion

        partial void OnDiffModeChanged(bool value)
        {
            if (value)
            {
                ResultCaption = "Difference";
                //SelectedMode = string.Empty;
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

        partial void OnStartDateChanged(DateTimeOffset value) => FindTheDate();

        partial void OnEndDateChanged(DateTimeOffset value) => FindTheDate();

        partial void OnSelectedModeChanged(string? value)
        {
            AddMode = value == "Add";
            FindTheDate();
        }

        partial void OnAddModeChanged(bool value) => FindTheDate();

        partial void OnSelectedYearChanged(int value) => FindTheDate();

        partial void OnSelectedMonthChanged(int value) => FindTheDate();

        partial void OnSelectedWeekChanged(int value) => FindTheDate();

        partial void OnSelectedDayChanged(int value) => FindTheDate();

        [RelayCommand]
        private void DateDiff() => FindTheDate();

        private void FindTheDate()
        {
            if (DiffMode)
            {
                var dtStart = StartDate;
                var dtEnd = EndDate;

                // If the startDate is later than the endDate, then swap their values for computation
                if (StartDate > EndDate)
                {
                    dtStart = EndDate;
                    dtEnd = StartDate;
                }

                DiffResult = Utility.DateDiff(dtStart.Date, dtEnd.Date);
                DiffInDays = ((int)(dtEnd.Date - dtStart.Date).TotalDays).InWords(TimeUnit.Day);
            }
            else
            {
                int factor = AddMode ? 1 : -1;
                DiffResult = StartDate.Date
                    .AddYears(SelectedYear * factor)
                    .AddMonths(SelectedMonth * factor)
                    .AddWeeks(SelectedWeek * factor)
                    .AddDays(SelectedDay * factor)
                    .ToLongDateString();
                DiffInDays = string.Empty;
            }
        }
    }
}
