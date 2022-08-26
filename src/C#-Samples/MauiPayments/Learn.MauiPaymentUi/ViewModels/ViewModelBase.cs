namespace Learn.MauiPaymentUi.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        private string _title;

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        protected INavigationService NavigationService { get; private set; }

        public virtual void Destroy()
        {
        }

        /// <summary>Navigated away from the page</summary>
        /// <param name="parameters">Navigation Parameters.</param>
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
        /// <param name="parameters">Navigation Parameters.</param>
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
