using System;
namespace UIMock
{
    public class HomePageViewModel : BaseViewModel
    {
        private List<MedicineReminderModel> _reminderList;


        public List<MedicineReminderModel> ReminderList
        {
            get => _reminderList;

            set
            {
                if (_reminderList == value) return;
                _reminderList = value;
                OnPropertyChanged(nameof(ReminderList));
            }
        }

        public HomePageViewModel()
        {
            _reminderList = new();
            InitList();
        }

        private void InitList()
        {
            ReminderList.Add(new MedicineReminderModel()
            {
                Medicine = "Acetaminophen",
                Dose = "10mg",
                Time = "Before launch 2:00 PM",
            });

            ReminderList.Add(new MedicineReminderModel()
            {
                Medicine = "Naproxen",
                Dose = "10mg",
                Time = "Before launch 2:10 PM",
            });

        }

    }

    public class MedicineReminderModel
    {
        public string Medicine { get; set; }
        public string Dose { get; set; }
        public string Time { get; set; }
    }

}

