using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VijayAnand.Toolkit.ObjectModel
{
    public partial class BaseViewModel : ObservableValidator, IDisposable
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private bool canLoadMore;

        [ObservableProperty]
        private string? title = string.Empty;

        [ObservableProperty]
        private string? subtitle = string.Empty;

        [ObservableProperty]
        private string? icon = string.Empty;

        [ObservableProperty]
        private string? header = string.Empty;

        [ObservableProperty]
        private string? footer = string.Empty;

        [ObservableProperty]
        private bool isValid = true;

        [ObservableProperty]
        private List<string> errors = new();

        public BaseViewModel()
        {
            ErrorsChanged += OnErrorsChanged;
        }

        //public IDialogService DialogService { get; protected set; }

        //public INavigationService NavigationService { get; protected set; }

        public bool IsNotBusy => !IsBusy;

        public bool Validate()
        {
            Errors.Clear();
            ValidateAllProperties();
            Errors = GetErrors().Select(e => e.ErrorMessage).ToList();
            IsValid = !HasErrors;
            return IsValid;
        }

        protected virtual void Initialize(IDictionary<string, object?>? parameters = null) { }

        protected virtual Task InitializeAsync(IDictionary<string, object?>? parameters = null)
            => Task.FromResult(0);

        protected void SetBusy(bool value) => IsBusy = value;

        protected virtual bool SetProperty<T>(ref T field,
                                                  T value,
                                                  [CallerMemberName] string? propertyName = null,
                                                  Action? onChanging = null,
                                                  Action? onChanged = null,
                                                  Func<T, T, bool>? validateValue = null)
        {
            // If value didn't change
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            // If value changed but didn't validate
            if (validateValue != null && !validateValue(field, value))
            {
                return false;
            }

            onChanging?.Invoke();
            field = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        private void OnErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
        {
            IsValid = !HasErrors;
        }

        public void Dispose()
        {
            ErrorsChanged -= OnErrorsChanged;
        }
    }
}
