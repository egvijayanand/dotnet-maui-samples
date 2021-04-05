using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;

namespace TestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public override IWindow CreateWindow(IActivationState activationState)
        {
            Forms.Init(activationState);
            return new MainWindow();
        }
    }
}