namespace MauiFocus;

public partial class MainPage : ContentPage
{
    readonly System.Timers.Timer _timer = new System.Timers.Timer();
    double _countdownValue = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        if (value > 0) StartButton.IsEnabled = true;

        _countdownValue = e.NewValue * 1000 * 60;
        _displayLabel.Text = string.Format("Focus for {0} minutes!", value);
    }

    private void StartButton_Clicked(object sender, EventArgs e)
    {
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Start();
            _timer.Elapsed += OnTimerElapsed;
            OptionsPanel.IsVisible = false;
            CountdownPanel.IsVisible = true;     
    }

    private void StopButton_Clicked(object sender, EventArgs e)
    {
        StopCountdown();
        ResetUI();
    }

    private void ResetUI()
    {
        _displayLabel.Text = "Click the '+' sign.";
        OptionsPanel.IsVisible = true;
        CountdownPanel.IsVisible = false;
        StartButton.IsEnabled = false;
        _stepper.Value = 0;
    }

    private void StopCountdown()
    {
        _timer.Enabled = false;
        _timer.Stop();
        _countdownValue = 0;
    }

    private void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        if (_countdownValue <= 0)
        {
            StopCountdown();
            MainThread.BeginInvokeOnMainThread(ResetUI);
        }
        else
        {
            _countdownValue -= 1000;            
        }

        MainThread.BeginInvokeOnMainThread(() =>
        {
            _timeLeftLabel.Text = string.Format("{0} minutes left to focus!", Math.Ceiling(_countdownValue / 60 / 1000) );
        });
    }
}

