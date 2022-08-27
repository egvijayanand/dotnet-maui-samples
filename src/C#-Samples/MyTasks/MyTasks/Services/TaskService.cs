using System.Collections.Generic;

namespace MyTasks.Services
{
    public class TaskService
    {
        private static TaskService _instance;

        public static TaskService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaskService();

                return _instance;
            }
        }

        public List<Models.Task> GetTasks()
        {
            // NOTE: In this sample the focus is on the UI. This is a Fake service.
            return new List<Models.Task>
            {
                new Models.Task { Name = "Customer meeting", Category = "Hangouts", Status = "Warning", Time = "6pm", Color = Color.FromArgb("#EEB611"), People = new List<Models.Person> { new Models.Person { Photo = "face2.jpg" }, new Models.Person { Photo = "face5.jpg" } }, Completed = false },
                new Models.Task { Name = "Catch up with Brian", Category = "Mobile Project", Status = "Warning", Time = "5pm", Color = Color.FromArgb("#EEB611"), Completed = false },
                new Models.Task { Name = "Approve final design review", Category = "Mobile Project", Status = "Problem", Time = "4pm", Color = Color.FromArgb("#5677CB"), Completed = false },              
                new Models.Task { Name = "Make new icons", Category = "Web App", Status = "Ready", Time = "3pm", Color = Color.FromArgb("#51C6BF"), Completed = false },
                new Models.Task { Name = "Design explorations", Category = "Company Website", Status = "Delayed", Time = "2pm", Color = Color.FromArgb("#EE376C"), Completed = false },
                new Models.Task { Name = "Lunch with Mary", Category = "Grill House", Status = "Ready", Time = "12pm", Color = Color.FromArgb("#51C6BF"), Completed = false },
                new Models.Task { Name = "Team meeting", Category = "Hangouts", Status = "Ready", Time = "10am", Color = Color.FromArgb("#51C6BF"), People = new List<Models.Person> { new Models.Person { Photo = "face2.jpg" }, new Models.Person { Photo = "face3.jpg" }, new Models.Person { Photo = "face4.jpg" }, new Models.Person { Photo = "face5.jpg" } }, Completed = false }
            };
        }
    }
}