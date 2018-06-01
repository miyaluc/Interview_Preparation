using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Max3
    {
        //Write a method that will return the 3 largest numbers in an array.
        public int[] FindMax3(int[] array)
        {
            //start by sorting array
            Array.Sort(array);

            //declare new int array with length of 3
            int[] newArray = new int[3];
            //declare int tracker to use as index for new array
            int tracker = 0;

            //implement for loopthat starts at the end of sorted array
            for (int i = array.Length - 1; i > array.Length - 4; i--)
            {
                newArray[tracker] = array[i];
                tracker++;
            }

            //output new items in new array to console
            foreach (int single in newArray)
            {
                Console.WriteLine(single);
            }
            return newArray;

            //int low = 0;
            //int high = array.Length - 1;

            //while (low <= high)
            //{
            //    int mid = (high + low) / 2;

            //}
        }

    }
}
