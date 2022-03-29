using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestApp.Models
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field,
                                                  T value,
                                                  [CallerMemberName] string propertyName = "",
                                                  Action? onChanging = null,
                                                  Action? onChanged = null,
                                                  Func<T, T, bool>? validateValue = null)
        {
            // if value didn't change
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            // if value changed but didn't validate
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
