using Learn.MauiPaymentUi.Services;

namespace Learn.MauiPaymentUi.ViewModels
{
    public class ReceiptViewModel : ViewModelBase
    {
        private readonly IStoreService _storeService;
        private string _totalPrice;

        public ReceiptViewModel(INavigationService navService, IStoreService store)
          : base(navService)
        {
            _storeService = store;

            Title = "Receipt";
            TotalPrice = "$ 0.00";
        }

        /// <summary>Navigatte back to main page.</summary>
        public DelegateCommand CmdFinished => new DelegateCommand(OnFinalizeOrderAsync);

        public string TotalPrice
        {
            get => _totalPrice;
            set => SetProperty(ref _totalPrice, value);
        }

        /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
        /// <param name="parameters">Navigation Parameters.</param>
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            // Get final price
            // Display on screen

            if (parameters.ContainsKey("total"))
            {
                TotalPrice = (string)parameters["total"];
            }
        }

        private async void OnFinalizeOrderAsync()
        {
            _storeService.Clear();

            var args = new NavigationParameters();
            args.Add("reset", true);

            await NavigationService.GoBackToRootAsync(args);
        }
    }
}
