using Microsoft.Maui;

namespace TestApp.Core
{
    public class Window : IWindow
    {
        public IMauiContext MauiContext { get; set; }

        public IPage Page { get; set; }
    }
}
