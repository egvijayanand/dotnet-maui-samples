namespace TestApp.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        private bool _isBusy;
        private string _title = string.Empty;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        protected void SetBusy(bool value)
        {
            IsBusy = value;
        }
    }
}