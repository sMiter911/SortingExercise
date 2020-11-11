using System;

namespace SortinExcercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variable Declaration
            string inputString;
            string cleanedInput;
            char[] stringArray; 
            char character;
            int stringLength;

            // User input
            Console.Write("Please Input String: ");
            inputString = Console.ReadLine().ToLower();

            // Method to clean space and punctuation from input
            cleanedInput = CleanInput(inputString);

            stringLength = cleanedInput.Length;
            stringArray = cleanedInput.ToCharArray(0, stringLength);


            for (int i = 1; i < stringLength; i++)
            {
                for (int j = 0; j < stringLength - i; j++)
                {
                    if (stringArray[j] > stringArray[j + 1])
                    {
                        character = stringArray[j];
                        stringArray[j] = stringArray[j + 1];
                        stringArray[j + 1] = character;
                    }
                }
            }
            Console.Write("After sorting: \n");
            foreach (char c in stringArray)
            {
                character = c;
                Console.Write("{0}", character);
            }
            Console.WriteLine("\n");

            Console.ReadLine();

        }

        public static string CleanInput(string text)
        {
            string output = System.Text.RegularExpressions.Regex.Replace(text, @"[^\w]", string.Empty);
            return output;
        }
    }
}
