﻿namespace TitleBarApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}
