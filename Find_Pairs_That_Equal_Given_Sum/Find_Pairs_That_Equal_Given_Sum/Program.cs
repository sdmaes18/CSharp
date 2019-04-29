using System;

namespace Find_Pairs_That_Equal_Given_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to find all pairs of integer array whose muplication is equal to a given number?

            // Given integer Array
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Target value of sum
            int target = 20;

            // Loop through given array.
            for(int i=0; i < intArray.Length; i++)
            {
                // Current value of i.
                int currentValue = intArray[i];

                // Compare current value with rest of index values.
                for(int j = i + 1; j < intArray.Length; j++)
                {
                    // next value to compare to currentValue.
                    int comparedValue = intArray[j];

                    // If currentValue and comapredValue == target's value print numbers and value to console.
                    if (currentValue * comparedValue == target)
                    {
                        Console.WriteLine($"({currentValue} * {comparedValue}) = {target}");
                    }
                }

            }

            // Used to keep console open until key stroke is entered.
            Console.ReadLine();
        }
    }
}
