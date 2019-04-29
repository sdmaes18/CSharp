using System;

namespace MissingNumberInArray
{
    class MissingNumberInArray
    {
        // Main Method
        static void Main(string[] args)
        {
            // QUESTION: How to find the missing number in given integer array of 1 to 100?

            // Array of integers. FYI missing number is 20.
            int[] intArray = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,21,22,23,24,25,26,27,28,29,30,
                               31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,
                               58,59,60, 61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,
                               85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100
            };

            // Holds the total sum of 1 to 100.
            int totalSum = 0;

            // Holds the total of all the number in intArray.
            int totalSumOfArray = 0;

            // Get total sum of 1-100.
            for (int i = 0; i < 101; i++)
            {
                totalSum += i;
            }

            // Get total sum of intArray.
            foreach (int i in intArray)
            {
                totalSumOfArray += i;
            }

            // Getting difference between totalSum and sum of given array...which is the missing number in array.
            int missingNumber = totalSum - totalSumOfArray;

            // Print missing number to console.
            Console.WriteLine(missingNumber);

            // Used to keep console open until key stroke.
            Console.ReadLine();
        }
    }
}
