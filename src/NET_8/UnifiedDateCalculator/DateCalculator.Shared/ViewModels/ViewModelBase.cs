using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable enable

namespace DateCalculator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

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

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
