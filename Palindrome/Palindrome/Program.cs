using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: Check if a given string is a palindrome.

            // Words the check if it's  palindrome or not.
            string wordOne = "steven";
            string wordTwo = "radar";
            string wordThree = "Deed";
            string wordFour = "racecar";
            string wordFive = "baba";

            // Call method to determine if it's a palindrome or not.
            CheckIfPalindrome(wordOne);
            CheckIfPalindrome(wordTwo);
            CheckIfPalindrome(wordThree);
            CheckIfPalindrome(wordFour);
            CheckIfPalindrome(wordFive);

            // Keep console open to read data output.
            Console.ReadLine();
        }

        /// <summary>
        /// Checks to see if a word is a palindrome.
        /// </summary>
        /// <param name="word">Word to check if it's a palindrome.</param>
        private static void CheckIfPalindrome(string word)
        {
            // List to hold individual characters of user input.
            List<char> charList = new List<char>();

            // Loop backwards through userInput and add each character to charList array.
            for (int i = word.Length - 1; i >= 0; i--)
            {
                charList.Add(word[i]);
            }

            // Used to hold list of reversed characters.
            StringBuilder sb = new StringBuilder();

            // add each char (s) in charList to the string builder.
            foreach (char s in charList)
            {
                sb.Append(s);
            }

            // holds the string builder (also convert it to a string).
            string reversedWord = sb.ToString();

            // If reversedWord and userInput are the same, the word is a palindrome.
            if (word.Equals(reversedWord))
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
        }
    }
}
