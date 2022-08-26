using Learn.MauiPaymentUi.Services;
using Learn.MauiPaymentUi.Views;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Learn.MauiPaymentUi.ViewModels
{
    public class PaymentViewModel : ViewModelBase
    {
        private readonly IStoreService _storeService;
        private string _cardCvv;
        private string _cardExpirationDate;
        private string _cardNumber;
        private string _purchaseText;

        public PaymentViewModel(INavigationService navService, IStoreService store)
          : base(navService)
        {
            _storeService = store;
            Title = "Verify Purchase";

            PurchaseText = $"Purchase for ${_storeService.TotalCost.ToString("##.00")}";
        }

        public string MaskedCvv => !string.IsNullOrEmpty(CardCvv) ? Regex.Replace(CardCvv, @"\d", "X") : string.Empty;

        public string CardCvv
        {
            get => _cardCvv;
            set
            {
                SetProperty(ref _cardCvv, value);
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MaskedCvv)));
            }
        }

        public string CardExpirationDate
        {
            get => _cardExpirationDate;
            set => SetProperty(ref _cardExpirationDate, value);
        }

        public string CardNumber
        {
            get => _cardNumber;
            set => SetProperty(ref _cardNumber, value);
        }

        public DelegateCommand CmdGoBack => new DelegateCommand(async () =>
        {
            var args = new NavigationParameters();
            await NavigationService.GoBackAsync(args);
        });

        public DelegateCommand CmdPurchase => new DelegateCommand(async () =>
        {
            if (IsValidPurchase())
            {
                // Pass along the total cost to Receipt page
                var args = new NavigationParameters
            {
          { "total", _storeService.TotalCost.ToString("##.00") }
            };

                await NavigationService.NavigateAsync(nameof(ReceiptView), args);
            }
            else
            {
                // TODO: Show warning prompt/dialog
            }
        });

        /// <summary>Button text with price.</summary>
        public string PurchaseText
        {
            get => _purchaseText;
            set => SetProperty(ref _purchaseText, value);
        }

        /// <summary>After the page has been pushed onto the stack, and it is now visible.</summary>
        /// <param name="parameters">Navigation Parameters.</param>
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        /// <summary>
        ///   Validate that there is a purchase being made.
        /// </summary>
        /// <returns>True if valid.</returns>
        private bool IsValidPurchase()
        {
            return _storeService.TotalCost > 0 &&
              !string.IsNullOrEmpty(CardCvv) &&
              !string.IsNullOrEmpty(CardExpirationDate);
        }
    }
}
