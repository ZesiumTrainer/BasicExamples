using IntroExamples.ClassExample;
using System;

namespace IntroExamples.ClassAggregation
{
    class Program
    {
        static void PrintDepartmentInfo (Department dep)
        {
            Console.WriteLine("{0} department teachers are:", dep.Name);
            for (int i = 0; i < dep.Teachers.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, dep.Teachers[i].ToString());
            }
        }

        static void Main(string[] args)
        {
            //Create new Department instances
            Department dep1 = new Department("Mobile");
            Department dep2 = new Department("Web");

            //Create new Person instances for teachers
            Person teacher1 = new Person("Marko", "Markovic");
            Person teacher2 = new Person("Petar", "Petrovic");

            dep1.Teachers.Add(teacher1);
            dep2.Teachers.Add(teacher2);

            PrintDepartmentInfo(dep1);
            PrintDepartmentInfo(dep2);

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
