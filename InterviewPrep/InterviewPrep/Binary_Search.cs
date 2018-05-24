using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Binary_Search
    {
        public int BinarySearch(int[] array, int key)
        {
            //implement for loop and set to length of provided array
            for (int i = 0; i < array.Length; i++)
            {
                //if array at i is equal to the number provided as an argument
                if (array[i] == key)
                {
                    Console.WriteLine($"{key} is at index {i}.");
                    //return that index
                    return i;
                }
            }
            //else if the key argument is not actually included in the array
            Console.WriteLine($"{key} cannot be found in the array.");
            //return -1
            return -1; 
        }
    }
}
