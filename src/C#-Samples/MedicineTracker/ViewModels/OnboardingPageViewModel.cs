using System;
using System.Windows.Input;
using UIMock;

namespace UIMock
{
    public class OnboardingPageViewModel : BaseViewModel
    {
        private List<string> onboardingList;
        private int position = 0;

        public List<string> OnboardingList
        {
            get => onboardingList;
            set
            {
                if (onboardingList == value) return;
                onboardingList = value;
                OnPropertyChanged(nameof(OnboardingList));
            }
        }

        public int Position
        {
            get => position;
            set
            {
                if (position == value) return;
                position = value;
                OnPropertyChanged(nameof(Position));
            }
        }


        public ICommand ICommandNavToLoginPage { get; set; }

        public OnboardingPageViewModel()
        {
            onboardingList = new();
            ICommandNavToLoginPage = new Command(() => NavigateToLoginPage());
            InitilizeOnboardingList();
            CarouselRotateService();
        }

        private void NavigateToLoginPage()
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private void InitilizeOnboardingList()
        {
            OnboardingList.Add("untitled4.png");
            OnboardingList.Add("untitled4.png");
            OnboardingList.Add("untitled4.png");
            OnboardingList.Add("untitled4.png");
        }

        private async void CarouselRotateService()
        {
            if (OnboardingList != null && OnboardingList.Any())
            {
                using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(5)))
                {
                    while (await timer.WaitForNextTickAsync())
                    {
                        Position = (Position + 1) % OnboardingList.Count;
                    }
                }
            }
        }
    }
}