using ClassFly.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ClassFlyXaml.ViewModels;

[INotifyPropertyChanged]
[QueryProperty(nameof(Course), "Course")]
public partial class CourseViewModel 
{
    [ObservableProperty]
	Course course;

    public CourseViewModel()
    {
    }
}
