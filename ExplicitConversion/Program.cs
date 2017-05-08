using System;

namespace IntroExamples.ExplicitConversion
{
    class Animal
    {
        public override string ToString()
        {
            return "I am an animal";
        }
    }

    class Reptile : Animal { }
    class Mammal : Animal { }

    class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;
            int a;
            
            //Explicit conversion from double ot int
            a = (int)x;
            Console.WriteLine("x = {0};\t\t\ta = {1}", x, a);

            Mammal mammal = new Mammal();

            try
            {
                TestConversion1(mammal);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught; Exception message: {0}", e.Message);
            }

            TestConversion2(mammal);

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }

        public static void TestConversion1(Animal animal)
        {
            Reptile r = (Reptile)animal;
            Console.WriteLine("Reptile value is: {0}", 
                r == null ? "null" : r.ToString());
        }

        public static void TestConversion2(Animal animal)
        {
            Reptile r = animal as Reptile;
            Console.WriteLine("Reptile value is: {0}", 
                r == null ? "null" : r.ToString());
        }
    }
}
