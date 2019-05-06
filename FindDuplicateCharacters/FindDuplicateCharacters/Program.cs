using System;
using System.Collections.Generic;

namespace FindDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to find duplicate characters in a String?

            // Given string.
            string startingString = "Quintessential";

            // Will hold all duplicate characters and the number of time it occurs.
            Dictionary<char, int> duplicates = new Dictionary<char, int>();

            // Turn string into all lowercase characters.
            startingString = startingString.ToLower();

            // Turn string into char array.
            char[] charArray = startingString.ToCharArray();

            // Sort Array
            Array.Sort(charArray);

            // Loop through each character
           foreach(char c in charArray)
            {
                // If duplicates contains the key already add 1 to the value.
                if (duplicates.ContainsKey(c))
                {
                    duplicates[c]++;
                }
                else
                {
                    // Add character and set value to 1. 
                    duplicates.Add(c, 1);
                }
            }

           // Print only characters that have 2 or more occurances to the console.
            foreach (var pair in duplicates)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
                }
            }
                
            // Used to kepp the console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
