using System.Windows.Input;
using Task = System.Threading.Tasks.Task;

namespace MyTasks.Controls
{
    /// <summary>
    /// Based on: https://github.com/alanbeech with a few changes (SelectedCommand, etc.).
    /// NOTE: Based on Alan's sample, there is a control with some nice properties: https://github.com/arqueror/Xamarin.Forms-RadialMenu
    /// </summary>
    public partial class FilterMenu : ContentView
    {
        public static readonly BindableProperty SelectedCommandProperty =
            BindableProperty.Create(nameof(SelectedCommand), typeof(ICommand), typeof(FilterMenu), null);

        public ICommand SelectedCommand
        {
            get { return (ICommand)GetValue(SelectedCommandProperty); }
            set { SetValue(SelectedCommandProperty, value); }
        }

        private bool _isAnimating = false;
        private uint _animationDelay = 150;

        public FilterMenu()
        {
            InitializeComponent();

            InnerButtonClose.IsVisible = false;
            InnerButtonMenu.IsVisible = true;

            HandleMenuCenterClicked();
            HandleCloseClicked();
            HandleOptionsClicked();
        }

        void HandleOptionsClicked()
        {
            HandleOptionClicked(N, "Ready");
            HandleOptionClicked(NW, "Warning");
            HandleOptionClicked(SW, "Delayed");
            HandleOptionClicked(S, "Problem");
        }

        void HandleOptionClicked(Image image, string value)
        {
            image.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await CloseMenu();

                    if (SelectedCommand?.CanExecute(value) ?? false)
                    {
                        SelectedCommand?.Execute(value);
                    }
                }),

                NumberOfTapsRequired = 1
            });
        }

        void HandleCloseClicked()
        {
            InnerButtonClose.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    await CloseMenu();
                }),

                NumberOfTapsRequired = 1
            });

        }

        private async Task CloseMenu()
        {
            if (!_isAnimating)
            {
                _isAnimating = true;

                InnerButtonMenu.IsVisible = true;
                InnerButtonClose.IsVisible = true;

                await HideButtons();
                await InnerButtonClose.RotateTo(0, _animationDelay);
                await InnerButtonClose.FadeTo(0, _animationDelay);
                await InnerButtonMenu.RotateTo(0, _animationDelay);
                await InnerButtonMenu.FadeTo(1, _animationDelay);
                await OuterCircle.ScaleTo(1, 100, Easing.Linear);
                InnerButtonClose.IsVisible = false;

                _isAnimating = false;
            }
        }

        private void HandleMenuCenterClicked()
        {
            InnerButtonMenu.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    if (!_isAnimating)
                    {
                        _isAnimating = true;

                        InnerButtonClose.IsVisible = true;
                        InnerButtonMenu.IsVisible = true;

                        await InnerButtonMenu.RotateTo(360, _animationDelay);
                        await InnerButtonMenu.FadeTo(0, _animationDelay);
                        await InnerButtonClose.RotateTo(360, _animationDelay);
                        await InnerButtonClose.FadeTo(1, _animationDelay);
                        await OuterCircle.ScaleTo(3.5, 100, Easing.Linear);
                        await ShowButtons();
                        InnerButtonMenu.IsVisible = false;

                        _isAnimating = false;

                    }
                }),

                NumberOfTapsRequired = 1
            });
        }

        private async Task HideButtons()
        {
            var speed = 25U;
            await N.FadeTo(0, speed);
            await NW.FadeTo(0, speed);
            await SW.FadeTo(0, speed);
            await S.FadeTo(0, speed);
        }

        private async Task ShowButtons()
        {
            var speed = 25U;
            await N.FadeTo(1, speed);
            await NW.FadeTo(1, speed);
            await SW.FadeTo(1, speed);
            await S.FadeTo(1, speed);
        }
    }
}