using System;
using System.IO;

namespace IntroExamples.UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                StreamWriter writer = new StreamWriter(@"E:\testTextFile.txt", true);
                try
                {
                    writer.WriteLine("This is a test of a writer using try and dispose on finnaly!");
                }
                finally
                {
                    ((IDisposable)writer).Dispose();
                }
            }

            //This is equivalent to the block above
            using (StreamWriter writer = 
                new StreamWriter(@"E:\testTextFile.txt", true))
            {
                writer.WriteLine("This is a test of a writer utilizing 'using statement!");
            }

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
