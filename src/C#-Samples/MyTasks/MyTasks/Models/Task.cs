using System.Collections.Generic;

namespace MyTasks.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public Color Color { get; set; }
        public List<Person> People { get; set; }
        public bool Completed { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}