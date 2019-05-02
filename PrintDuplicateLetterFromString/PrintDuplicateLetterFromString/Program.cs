using System;
using System.Collections.Generic;

namespace PrintDuplicateLetterFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to Print duplicate characters from String ?

            // Given starting string.
            string startingString = "This is to keep my C# skills sharp";

            // Create a list to hold characters that repeat.
            List<char> charList = new List<char>();

            // Make every character uppercase in starting string.
            startingString = startingString.ToUpper();

            // Loop through each character in the startingString.
            foreach (char c in startingString)
            {
                // If c is an empty string (space) simply continue.
                if (c.Equals(' '))
                {
                    continue;
                }

                // Add character to charList if it's not already in it.
                if (!charList.Contains(c))
                {
                    charList.Add(c);
                }
            }

            // Printing original string.
            Console.WriteLine(startingString);

            // Printing charList that holds chars. that are duplicates.
            foreach(char c in charList)
            {
                Console.Write(c + " ");
            }

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
