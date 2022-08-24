namespace ClassFly.Core.Models;

public class DataService
{
    public static List<Course> Search(string searchTerm)
    {
        var courses = GetCourses();
        courses = courses.Where(x => x.Matches(searchTerm)).ToList();
        return courses;
    }


    public static List<Course> GetCourses() => new()
    {
        new Course
        {
            Name = "Guitar",
            Image = "guitar.png",
            MemberCount = 45,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett",Image = "scarlett.png", FollowerCount = 70},
                new Mentor {Name = "Jhony",Image = "jhony.png", FollowerCount = 150},
                new Mentor {Name = "Linda",Image = "linda.png", FollowerCount = 30},
            }},
        new Course
        {
            Name = "Saxophone",
            Image = "saxophone.png",
            MemberCount = 14,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett",Image = "scarlett.png", FollowerCount = 70},
                new Mentor {Name = "Jhony",Image = "jhony.png", FollowerCount = 150},
                new Mentor {Name = "Linda",Image = "linda.png", FollowerCount = 30},
            }
        },
        new Course{Name = "Drums",
            Image = "drums.png",
            MemberCount = 19,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett",Image = "scarlett.png", FollowerCount = 70},
                new Mentor {Name = "Jhony",Image = "jhony.png", FollowerCount = 150},
                new Mentor {Name = "Linda",Image = "linda.png", FollowerCount = 30},
            }
        },
        new Course{Name = "Piano",
            Image = "piano.png",
            MemberCount = 27,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett", Image = "scarlett.png", FollowerCount = 70},
                new Mentor {Name = "Jhony",Image = "jhony.png", FollowerCount = 150},
                new Mentor {Name = "Linda",Image = "linda.png", FollowerCount = 30},
            }
        },
        new Course
        {
            Name = "Double Bass",
            Image = "bass.png",
            MemberCount = 100,
            Mentors = new ()
            {
                new Mentor {Name = "Scarlett",Image = "scarlett.png", FollowerCount = 70},
                new Mentor {Name = "Jhony",Image = "jhony.png", FollowerCount = 150},
                new Mentor {Name = "Linda",Image = "linda.png", FollowerCount = 30},
            }
        },
    };
}
