using System;
using System.Collections.Generic;

namespace FindDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: How to find duplicate numbers in an array if it contains multiple duplicates ( more than 2 )?

            // Given Array
            int[] intArray = {2, 10, 4, 6, 8, 10, 2, 12, 10, 8, 14, 16, 2, 8, 20, 10, 20, 20 };

            // Used to store a count number.
            int count = 0;

            // List to hold numbers that have multipes in intArray.
            List<int> intList = new List<int>();

            // Sort the array.
            Array.Sort(intArray);

            // Loops through intArray
            for (int i=0; i < intArray.Length; i++)
            {
                // Current Value.
                int current = intArray[i];

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    // Determine if current value equals compared value of j and count is < 2
                    if (current == intArray[j] && count < 2)
                    {
                        // add +1 to count. 
                        count++;
                    }
                    else
                    {
                        // reset count to 0.
                        count = 0;
                    }

                    // if count >= 2 and list doesn't contain the current value. Add value to the list.
                    if(count >= 2 && !intList.Contains(current))
                    {
                        intList.Add(current);
                    }
                }

            }

            // Print intArray to console.
            foreach(int i in intArray)
            {
                Console.Write(i + " ");
            }

            // Prints out: "numbers that contain duplicates"
            Console.Write("\nNumbers that contain duplicates: ");

            // Print out the list, which again contains the numbers that have duplicates.
            foreach (int i in intList)
            {
                Console.Write(i + " ");
            }

            // Used to keep console open until entered key stroke.
            Console.ReadLine();
        }
    }
}
