using ClassFly.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ClassFlyXaml.Pages;

namespace ClassFlyXaml.ViewModels;

[INotifyPropertyChanged]
public partial class ClassListViewModel
{
    private DataService dataservice;

    [ObservableProperty]
    private ObservableCollection<Course> courses;

    [ObservableProperty]
    private Course selectedCourse;


    public ClassListViewModel()
    {
        courses = new ObservableCollection<Course>(DataService.GetCourses());
    }

    [ICommand]
    public async Task GoToCourseDetails(Course course)
    {
        if (course == null)
            return;

        await Shell.Current.GoToAsync(nameof(CoursePage), true, new Dictionary<string, object>
        {
            {"Course", course}

        });
    }

    [ICommand]
    private void SearchTerm(string searchTerm)
    {
        if (!string.IsNullOrEmpty(searchTerm))
        {
            courses = new ObservableCollection<Course>(DataService.Search(searchTerm));
            OnPropertyChanged(nameof(Courses));
        }
        else
        {
            courses = new ObservableCollection<Course>(DataService.GetCourses());
            OnPropertyChanged(nameof(Courses));
        }
    }

}
