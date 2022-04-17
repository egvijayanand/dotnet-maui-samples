namespace RazorLib
{
    public class AppState
    {
        public event Action? OnChanged;

        public int CurrentCount { get; private set; }

        public void InitCount(int value)
        {
            CurrentCount = value;
            NotifyStateChanged();
        }

        public void IncrementCount()
        {
            CurrentCount++;
            NotifyStateChanged();
        }

        public void ResetCount()
        {
            CurrentCount = 0;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChanged?.Invoke();
        }
    }
}
