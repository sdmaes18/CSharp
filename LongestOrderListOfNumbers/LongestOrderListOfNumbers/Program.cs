using System;
using System.Collections.Generic;

namespace LongestOrderListOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: Given an unordered list of numbers, return the long set of ordered numbers.
            // 12, 14, 1, 2, 3, 7, 44, 32: will return 1,2,3

            // Starting List of Numbers.
            List<int> startingList = new List<int> { 15,17,19,11,15,16,17,4,5,7,18,9,10 };

            // Used to get the longest consecutive list of numbers from above list.
            List<int> currentLongest= new List<int>();

            // Final list that contains the longest consecutive list of integers.
            List<int> finalLongest = new List<int>();

            // to start add the first element of our given list of integers to our placeholder list.
            currentLongest.Add(startingList[0]);

            // Loop through the starting list including the last element.
            for (int i = 0; i <= startingList.Count - 1; i++)
            {
                // compare current element of i with the rest of the list.
                for (int j = i + 1; j <= startingList.Count - 1; j++)
                {
                    // If current element at i is smallest than the next element, add it to
                    // the current longest list and increment i by 1.
                    if (startingList[i] < startingList[j])
                    {
                        currentLongest.Add(startingList[j]);
                        i++;
                    }
                    else
                    {
                        // Determines which list is longer and makes finalLongest that list.
                        // Whatever one is longer has more consecutive integers in it.
                        finalLongest = DetermineListCounts(currentLongest, finalLongest);

                        // Assign currentLongest to a new list and add the compared element into list.
                        // Break to move onto next iteration of loop.
                        currentLongest = new List<int>();
                        currentLongest.Add(startingList[j]);
                        break;
                    }

                }
            }

            // One last check to determine who has the longest consecutive numbers in its list.
            finalLongest = DetermineListCounts(currentLongest, finalLongest);

            // Print the finalLonest list.
            foreach (int i in finalLongest)
            {
                Console.WriteLine(i);
            }

        }

        /// <summary>
        /// Determines which list is longer in lenght and returns that list.
        /// </summary>
        /// <param name="firstList">First list to compare.</param>
        /// <param name="secondList">Second list to compare.</param>
        /// <returns>The list who has the longer length.</returns>
        public static List<int> DetermineListCounts(List<int> firstList, List<int> secondList)
        {
            // Declare a new list.
            List<int> output = new List<int>();

            // If firstList has a longer length than the secondList, assign output to the firstList.
            // if its not assign it the the secondList.
            if (firstList.Count > secondList.Count)
            {
                output = firstList;
            }
            else
            {
                output = secondList;
            }

            // return output.
            return output;
        }
    }
}
