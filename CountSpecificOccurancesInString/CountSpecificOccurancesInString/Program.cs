using System;

namespace CountSpecificOccurancesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to count the occurrence of a given character in String?

            // Starting String.
            string startingString = "My favorite hobby is golf";

            // Used to keep track of occurances or given letter.
            int counter = 0;

            // Used to hold user entered character.
            char letter = default(char);

            // Print string to console.
            Console.WriteLine(startingString);
            
            // Get input from user asking to type a single character
            Console.WriteLine("Please enter a single character: ");
            letter = Console.ReadKey().KeyChar;

            // While user entered is not a letter ask again. input must be a character a-z
            while (!char.IsLetter(letter))
            {
                Console.WriteLine("Please enter a single character: ");
                letter = Console.ReadKey().KeyChar;
            }
            

            // Loops through characters in startingString.
            foreach (char c in startingString)
            {
                // If c == user entered character, add 1 to the counter.
                if (c.Equals(letter))
                   counter++;
            }

            // Prints empty line and message to user.
            Console.WriteLine();
            Console.WriteLine($"{letter} occurs {counter} times.");

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
