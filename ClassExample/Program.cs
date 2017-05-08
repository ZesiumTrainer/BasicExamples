using System;

namespace IntroExamples.ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Person instance
            Person person1 = new Person();
            Console.WriteLine(person1.ToString());

            //Change person1 name and last name
            person1.Name = "Marko";
            person1.LastName = "Markovic";
            Console.WriteLine(person1.ToString());

            //Create a new Person instance with name and lastName forwarded in a constructor
            Person person2 = new Person("Petar", "Petrovic");
            Console.WriteLine(person2.ToString());

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
