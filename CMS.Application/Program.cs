using UI.Model;

namespace CMS.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Access Static Field by class name
            // For Constant & Static Value Access doesn't required Instance of Class
            Console.WriteLine("Static Field Value :- " + Student.MaxEnrolledCoursesInternal);
            Console.WriteLine("Constant Field Value :- " + Student.MaxEnrolledCourses);


            Student student = new Student();
            student.FirstName = "Test";
            Console.WriteLine("Student Class Value :- "+ student.FirstName);


            //  For ReadOnly Value Access Required Instance of Class
            Console.WriteLine("Student ReadOnly Value :- " + student.MaxEnrolledCoursesExternal);

            Student student1 = new Student()
            {
                StudentId = 2,
                FirstName = "Test1",
                LastName = "Test1 LastName"
            };
            Console.WriteLine(student1.StudentId);
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student1.LastName);

            // Access Static Field by class name
            Console.WriteLine("Static Field Value :- "+ Student.MaxEnrolledCoursesInternal);

            Staff staff = new Staff();
        }
    }
}
