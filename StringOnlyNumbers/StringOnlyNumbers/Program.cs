using System;
using System.Text.RegularExpressions;

namespace StringOnlyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: Determine if a string contains only numbers.

            // Given strings
            string firstString = "Steven";
            string secondString = "St3v3n";
            string thirdString = "573039";

            // Use a regex to compare string for numbers only.
            Regex numbersOnly = new Regex(@"^-?[0-9][0-9,\.]+$");

            // Determines if firstString contains only numbers.
            if (numbersOnly.IsMatch(firstString))
            {
                Console.WriteLine($"{ firstString} contains only numbers");
            }
            else
            {
                Console.WriteLine($"{firstString} doesn't contain only numbers");
            }

            // Determines if secondString contains only numbers.
            if (numbersOnly.IsMatch(secondString))
            {
                Console.WriteLine($"{secondString} contains only numbers");
            }
            else
            {
                Console.WriteLine($"{secondString} doesn't contain only numbers");
            }

            // // Determines if thirdString contains only numbers.
            if (numbersOnly.IsMatch(thirdString))
            {
                Console.WriteLine($"{thirdString} contains only numbers");
            }
            else
            {
                Console.WriteLine($"{thirdString} doesn't contain only numbers");
            }

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
