using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Array_Reversal
    {
        public int[] ReverseArray(int[] input)
        {
            //declare new int array called newArray, with the length of input
            int[] newArray = new int[input.Length];
            //for the length of the input array
            for (int i = 0; i < input.Length; i++)
            {
                //swap the indices
                newArray[input.Length - i - 1] = input[i];
            }
            Console.WriteLine("Here is the old array:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]}");
            }

            Console.WriteLine("Here is the new array:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"{newArray[i]}");
            }
            return newArray;
        }

        public void Reverse(int[] input)
        {
            //implement for loop with length of input divided by 2
            for (int i = 0; i < input.Length / 2; i++)
            {
                int other = input.Length - i - 1;
                int temp = input[i];
                input[i] = input[other];
                input[other] = temp;
            }
            //
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
