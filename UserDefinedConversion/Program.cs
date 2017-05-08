using System;

namespace IntroExamples.UserDefinedConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            //Implicit conversion
            RomanNumeral numeral1 = a;
            Console.WriteLine("a = {0};\t\t\tnumeral1 = {1}", a, numeral1);

            RomanNumeral numeral2 = 10;
            //Explicit conversion
            int b = (int)numeral2;
            string num = (string)numeral2;
            Console.WriteLine("b = {0};\t\t\tnumeral2 = {1};\t\t\tnum = {2}", b, numeral2, num);

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
