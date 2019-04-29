using System;

namespace UnsortedLargeAndSmall
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to find the largest and smallest number in an unsorted integer array?

            // Given integer array.
            int[] intArray = { 17, 12, 55, 8, 12, 4, 21, 24, 52, 34, 19, 1, 100 };

            // Holds smallest number. 
            int smallest = intArray[0];

            // Holds largest number.
            int largest = intArray[1];

            // Loop through given array
            for (int i = 0; i < intArray.Length; i++)
            {
                // Get current value in array.
                int currentValue = intArray[i];

                // If current value is < than current smallest, re-assign the smallest value
                // to current value.
                if (currentValue < smallest)
                {
                    smallest = intArray[i];
                }

                // If current value is > current smallest, re-assign the largest value
                // to current value.
                if (currentValue > largest)
                {
                    largest = intArray[i];
                }
            }


            // Output integer array.
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }

            // adding a line break.
            Console.WriteLine("");

            // Output smallest number.
            Console.WriteLine("Smallest: " + smallest);

            // Output largest number.
            Console.WriteLine("Largest: " + largest);

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
