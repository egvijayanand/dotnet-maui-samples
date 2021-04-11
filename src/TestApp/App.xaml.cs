﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

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
			Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

			return new MainWindow();
		}
	}
}