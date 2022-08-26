using Learn.MauiPaymentUi.Services;
using Learn.MauiPaymentUi.Views;

namespace Learn.MauiPaymentUi.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IStoreService _storeService;
        private bool _item1Checked;
        private bool _item2Checked;
        private bool _item3Checked;

        public MainViewModel(ISemanticScreenReader screenReader, INavigationService navService, IStoreService storeService)
          : base(navService)
        {
            _screenReader = screenReader;
            _storeService = storeService;

            Title = "Payment Sample";
        }

        public DelegateCommand CmdCheckout => new DelegateCommand(() =>
        {
            GetCartItems();

            NavigationService.NavigateAsync(nameof(PaymentView));
        });

        public DelegateCommand CmdResetCart => new DelegateCommand(OnResetCart);

        public bool Item1Checked
        {
            get => _item1Checked;
            set => SetProperty(ref _item1Checked, value);
        }

        public bool Item2Checked
        {
            get => _item2Checked;
            set => SetProperty(ref _item2Checked, value);
        }

        public bool Item3Checked
        {
            get => _item3Checked;
            set => SetProperty(ref _item3Checked, value);
        }

        private ISemanticScreenReader _screenReader { get; }

        /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
        /// <param name="parameters">Navigation Parameters.</param>
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            // Navigated from ReceiptView
            if (parameters.ContainsKey("reset"))
            {
                OnResetCart();
            }
        }

        private void GetCartItems()
        {
            _storeService.Clear();

            if (Item1Checked)
                _storeService.AddItem(StoreItem.Hat, 1);

            if (Item3Checked)
                _storeService.AddItem(StoreItem.Shirt, 1);

            if (Item2Checked)
                _storeService.AddItem(StoreItem.Shoes, 1);
        }

        private void OnResetCart()
        {
            _storeService.Clear();

            Item1Checked = false;
            Item2Checked = false;
            Item3Checked = false;

            ////// Update accessability screen reader. Ref: https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/accessibility
            ////_screenReader.Announce(Text);
        }
    }
}
