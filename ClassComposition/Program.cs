using IntroExamples.ClassAggregation;
using System;

namespace IntroExamples.ClassComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new School instance
            School school = new School("Zesium", 5);

            Console.WriteLine("School {0} has {1} students, and {2} departments. Departments are:", 
                school.SchoolName, school.StudentsCount, school.Departments.Count);
            foreach(Department dep in school.Departments)
            {
                Console.WriteLine("{0} department which has {1} teachers working for it.", 
                    dep.Name, dep.Teachers.Count);
            }

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
