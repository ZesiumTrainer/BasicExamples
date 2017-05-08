using System;

namespace IntroExamples.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<double, double>[] divisionPairs = 
                { new Tuple<double, double>(30, 5), new Tuple<double, double>(30, 0) };

            foreach(Tuple<double, double> pair in divisionPairs)
            {
                try
                {
                    Console.WriteLine("Dividing {0} by {1}", pair.Item1, pair.Item2);
                    double divisionResult = SafeDivision(pair.Item1, pair.Item2);
                    Console.WriteLine("Division result is {0}", divisionResult);
                }
                catch (Exception e)
                {
                    Console.Write("Exception has been thrown!\nException message: {0}\nStackTrace: {1}\n",
                        e.Message, e.StackTrace);
                }
                finally
                {
                    Console.WriteLine("try/catch block has been executed!");
                }
            }

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }

            return x / y;
        }
    }
}
