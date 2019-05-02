using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to check if two Strings are anagrams of each other?

            // True or false value to determine if two strings are anagrams.
            bool flag = false;

            // Starting strings.
            string firstString = "Could";
            string secondString = "Cloud";

            // Convert strings to both be upper case.
            firstString = firstString.ToUpper();
            secondString = secondString.ToUpper();

            // Convert each string to a char. array.
            char[] firstCharArray = firstString.ToCharArray();
            char[] secondCharArray = secondString.ToCharArray();

            // Sort each string.
            Array.Sort(firstCharArray);
            Array.Sort(secondCharArray);

            // Loop through firstChaArray and compare current value with secondCharArray same index.
            // If each index is the same they are anagrams.
            for(int i=0; i < firstCharArray.Length; i++)
            {
                // If current value = same index value in other char. array, continue on with process.
                if (firstCharArray[i].Equals(secondCharArray[i]))
                {

                    flag = true;
                    continue;
                }
                else
                {
                    // two comparing values are not the same so we know words are not anagrams.
                    flag = false;
                    break;
                }
            }

            // Print starting words.
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);

            // Prints a T/F value if they're anagrams of one another.
            Console.WriteLine($"{flag}: words are " + ((flag) ? "anagrams" : "not anagrams"));

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
