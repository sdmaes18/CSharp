using System;

namespace CountVowlesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUETION: How to count a number of vowels and consonants in a given String?

            // Starting string.
            string startingString = "Today is monday";

            // Hold the number of vowels in a given string.
            int vowels = 0;

            // Hold the number of constants in a given string.
            int constants = 0;

            // Turn startingString to lowercase characters.
            string lowercaseString= startingString.ToLower();

            // Removing white space from string.
            string finalString = lowercaseString.Replace(" ", string.Empty);

            // Loop through each character
            foreach(char c in finalString)
            {
                // Switch on (c). if it's a vowel add 1 to vowels otherwise add 1 to constants
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        break;
                    default:
                        constants++;
                        break;
                }
            }

            // Print original String.
            Console.WriteLine(startingString);

            // Write to console the number of vowels and constants.
            Console.WriteLine($"Number of vowels: {vowels}. Number of constants: {constants}");

            // Used to keep the console open until key stroked is entered.
            Console.ReadLine();
        }
    }
}
