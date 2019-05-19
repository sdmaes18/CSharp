using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            // QUESTION: Given an array of integers, return a new array such that each element at
            // index i of the new array is the product of all the numbers in the original array except the one at i.

            // Starting array
            int[] intArray = {1,4,2,5};

            // New Array to hold new numbers;
            int[] finishedArray = new int[intArray.Length];

            // Loop through each index of intArray.
            for(int i = 0; i < intArray.Length; i++)
            {
                // Holds the product of all the numbers being multiplied.
                int product = 1;
                
                // Loop through every other index.
                for (int j = 0; j < intArray.Length; j++)
                {
                    // if I and J are different multiply product by intArray[j].
                    if (j != i)
                    {
                        product *= intArray[j];
                    }

                }
                
                // Add product to current index of i into finishedArray.
                finishedArray[i] = product;
            }

            // Printing new finished array.
            foreach(int i in finishedArray)
            {
                Console.WriteLine(i);
            }

            // Used to keep console open.
            Console.ReadLine();
        }
    }
}
