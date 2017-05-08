using IntroExamples.ClassExample;
using System;

namespace IntroExamples.ClassAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person teacher1 = new Person("Marko", "Markovic");
            Person teacher2 = new Person("Petar", "Petrovic");

            Student student1 = new Student("Mirko", "Mirkovic");
            Student student2 = new Student("Sava", "Savanovic");

            //Add associations
            student1.AddNewAssociatedTeacher(teacher1);
            student1.AddNewAssociatedTeacher(teacher2);

            foreach(Person t in student1.AssociatedTeachers)
            {
                Console.WriteLine("Student {0} is associated with teacher {1}", 
                    student1.ToString(), t.ToString());
            }

            student2.AddNewAssociatedTeacher(teacher1);
            student2.AddNewAssociatedTeacher(teacher1);

            foreach (Person t in student2.AssociatedTeachers)
            {
                Console.WriteLine("Student {0} is associated with teacher {1}", 
                    student2.ToString(), t.ToString());
            }

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
