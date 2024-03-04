
public class Student : Person
{ 
    Dictionary<string, int> _courses = new Dictionary<string, int>();
    List<int> _grades = new List<int>();

    public Student(string name, string address) : base(name, address)
    {
    }

    public void AddCourseGrade(string course, int num,int grade)
    {
        if (_courses.Count < 30)
        {
            _courses.Add(course, num);
            _grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Student can not add a course");
        }
    }

    public void PrintGrades()
    {
        foreach (var it in _grades)
        {
            System.Console.Write(it+ " ");
        }
    }
    public void PrintCourses()
    {
        foreach (var it in _courses)
        {
            Console.WriteLine($"{it.Key}: {it.Value}");
        }
    }

    public double GetAverageGrades()
    {
        if (_courses.Count == 0)
        {
            return 0;
        }
            return _grades.Average();
    }

    public override string ToString()
    {
        return $"Student: {base.ToString()}";
    }
}