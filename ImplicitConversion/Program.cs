using IntroExamples.ClassExample;
using System;

namespace IntroExamples.ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallNum = 234141242;

            //Implicit conversion from int to long
            long bigNum = smallNum;

            Console.WriteLine("smallNum: {0}; bugNum: {1}", smallNum, bigNum);

            //Create a Student instance
            Student student = new Student("Marko", "Markovic", 8.00);
            Console.WriteLine("Student: {0}", student.ToString());

            //Implicit conversion from derived type to base type
            Person person = student;
            Console.WriteLine("Person: {0}", person.ToString());

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
