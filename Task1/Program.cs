
var std1 = new Student("Mansur","Azamzoda");
std1.SetAddress("Jomi 10");
std1.AddCourseGrade("C#",1,20);
std1.AddCourseGrade("Java",2,21);
std1.AddCourseGrade("C++",3,40);
System.Console.WriteLine(std1.GetName());
std1.PrintCourses();
System.Console.WriteLine(std1.GetAverageGrades());
System.Console.WriteLine(std1.ToString());

var tchr1 = new Teacher("Muhammadjon","Profsoyuz");
tchr1.AddCourse("C++",5);
tchr1.GetCourses();