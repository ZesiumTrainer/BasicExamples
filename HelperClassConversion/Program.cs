using System;

namespace IntroExamples.HelperClassConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteArray = { 0, 18, 0, 28 };

            if(BitConverter.IsLittleEndian) //Depends on processor architecture
            {
                Array.Reverse(byteArray);
            }

            int convertedByteArray = BitConverter.ToInt32(byteArray, 0);
            Console.WriteLine("Byte array {0} is converted to integer {1}",
                string.Join(", ", byteArray), convertedByteArray);

            //Convert string to integer values
            string[] stringInputs = { "-205", "test" };
            foreach(string input in stringInputs)
            {
                int parsed;
                if(Int32.TryParse(input, out parsed))
                {
                    Console.WriteLine("String {0} has been parsed to Int32 value: {1}",
                        input, parsed);
                }
                else
                {
                    Console.WriteLine("String {0} could not be parsed to Int32 value!",
                        input);
                }
            }

            //Convert char to hexadecimal values
            string inputString = "Zesium";
            char[] inputChars = inputString.ToCharArray();
            foreach(char letter in inputChars)
            {
                int value = Convert.ToInt32(letter);
                string hexOutput = String.Format("{0:X}", value);
                Console.WriteLine("Hexadecimal value of letter {0} is 0x{1}",
                    letter, hexOutput);
            }

            //Exit the program
            Console.Write("Press any key to terminate the program...");
            Console.ReadKey();
        }
    }
}
