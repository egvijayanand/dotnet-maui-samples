namespace TitleBarApp
{
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        public MyWindow(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}
