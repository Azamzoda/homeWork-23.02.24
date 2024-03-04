
public class Teacher : Person
{


     Dictionary<string, int> _courses = new Dictionary<string, int>();

    public Teacher(string name, string address) : base(name, address)
    {
    }

    public bool AddCourse(string course, int numCourse)
    {
        if (_courses.Count < 5)
        {
            _courses.Add(course, numCourse);
            return true;
        }
        else
        {
            Console.WriteLine("Сourse limit reached");
            return false;
        }
    }

    public bool RemoveCourse(string course)
    {
        
        _courses.Remove(course);
        return true;
    }

    public void GetCourses()
    {
        foreach (var course in _courses)
        {
            Console.WriteLine(course);
        }
    }

    public override string ToString()
    {
        return $"Teacher: {base.ToString()}";
    }
}