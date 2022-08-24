using ClassFly.Core.Models;
using ClassFlyXaml.ViewModels;

namespace ClassFlyXaml.Pages;

public partial class CoursePage : ContentPage
{
	public CoursePage(CourseViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
    }
}