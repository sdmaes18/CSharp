using System;
using System.Linq;

namespace RemoveDuplicatesFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to remove duplicates from a given array in C#?

            // Given Array to start with.
            int[] intArray = { 2,15,5,12,42,36,12,18,9,10,11,53,85,12 };

            // Create a new array with distinct values and convert it to array.
            int[] newArray = intArray.Distinct().ToArray();

            // Sort new array.
            Array.Sort(newArray);

            // Assign new array to old starting array.
            intArray = newArray;

            // Loop through original array and print values.
            foreach( int i in intArray)
            {
                Console.Write(i + " ");
            }

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
