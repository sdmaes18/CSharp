using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicateNumber
{
    class FindDuplicate
    {
        // Starts the program.
        static void Main(string[] args)
        {
            // Question: How to find the duplicate number on a given integer array?
                
            // Problem set integer array.
            int[] intArray = { 2, 14, 54, 17, 8, 9, 12, 11, 22, 16, 54 };

            // Will hold the duplciate number. 0 is default.
            int duplicateNumber = 0;

            // Step 1: Sort the array.
            Array.Sort(intArray);

            // Step 2: Loop through array and compare two adjacted values. 
            //         If they're the same value, we have the duplicate number.

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] == intArray[i + 1])
                {
                    duplicateNumber = intArray[i];
                    break;
                }
            }

            // Print duplicate number to the console. (54).
            Console.Write(duplicateNumber);

            // Used to keep the console window open until key stroke entered.
            Console.ReadLine();
        }
    }
}
