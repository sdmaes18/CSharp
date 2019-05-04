using System;
using System.Linq;

namespace FindFirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: Find the first non-repeating firstNonRepeating in a string.

            // Given string.
            string startingString = "eekkktstrr";

            // Turns startingString into char array.
            char[] charArray = startingString.ToCharArray();

            // Character to hold first non repeating value.
            char firstNonRepeating = default(char);
  
            // Loop through distinct contents of the charArray.
            foreach (char distinctChar in charArray.Distinct())
            {
                if (charArray.Count(x => x == distinctChar) == 1)
                    firstNonRepeating = distinctChar;
            }

            // Prints first non repeating element.
            Console.WriteLine(firstNonRepeating);

            // Used to keep console open until key stroked is entered.
            Console.ReadLine();
        }
    }
}
