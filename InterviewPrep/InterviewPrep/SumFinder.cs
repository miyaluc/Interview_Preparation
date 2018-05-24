using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class SumFinder
    {
        //     Given an array of integers and another number x, find if there exist a pair of number in the array whose           sum is x.
        //Input : 
        //arr = [0, 1, 2, 5, 6], x = 10
        //arr = [0, 1, 2, 5, 6], x = 6
        //arr = [0, 1, 2, 5, 6], x = 3
        //arr = [0, 1, 2, 5, 6], x = 12
        //arr = { 0, 2, 8, 7, 1, -5 }, x = -5;
        //Ouput: 
        //No
        //Yes
        //Yes
        //No
        //Yes

        public string FindSumPair(int[] array, int x)
        {
            HashSet<int> hashset = new HashSet<int>();
            //for the length of the array
            for (int i = 0; i < array.Length; i++)
            {
                hashset.Add(array[i]);
                //temp is the remainder needed for array[i] to get to x
                int temp = x - array[i];
                //if hashset contains temp
                if (hashset.Contains(temp))
                {
                    Console.WriteLine("yes");
                    //Console.WriteLine($"{temp} and {x} are in the array");
                    return "yes";
                }
                //else 
                {
                    Console.WriteLine("no");
                }
            }
            //output yes

            //output no
            return null;
        }
        //Bonus 1:
        //Given an array of integers and a another number x, find all pairs of numbers whose sum is equal to x.
        //Input : 
        //arr = [0, 1, 2, 5, 6, 7], x = 7
        //Ouput:
        //[0, 7]
        //[1,6]
        //[2, 5]
        public void FindNumPairs(int[] array, int x)
        {
            int[] newArray = new int[array.Length];
            //running through the length of the array
            for (int n = 0; n < array.Length; n++)
            {
                //comparing array at n to array at m
                for (int m = n; m < array.Length; m++)
                {
                    //if we are not adding the same number twice
                    if (n != m)
                    {
                        int sum = array[m] + array[n];

                        if (sum == x) // && !hash.Contains(array[m]
                        {
                            Console.Write($"{array[m]}, {array[n]}");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No pairs exist with {array[n]} that sum up to {x}.");
                    }
                }
            }

        }

        //Bonus 2: 
        //Given an array of integers and another number x, find all combination of numbers in the array whose sum is equal to x.
        //Input : 
        //arr = [0, 1, 2, 5, 6, 7], x = 7
        //Ouput:
        //[7] [0,7] [0, 1, 6] [1, 6] [ 2, 5]
        public void FindAllCombos(int[] array, int x)
        {
            List<int> list = new List<int>();
            foreach (int a in array)
            {
                list.Add(a);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    list.Add(array[i]);
                    Console.WriteLine($"[{array[i]}]");
                    list.Clear();
                    return;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    int sum = array[i];

                    while (sum < x)
                    {
                        sum += array[j];
                    }
                    if (sum == x)
                    {

                    }
                    //if (array[i] + array[j] == x)
                    //{
                    //    list.Add(array[i]);
                    //    list.Add(array[j]);
                    //    Console.WriteLine($"{array[i]}, {array[j]}");
                    //}
                    //if (array[i] + array[j] < x)
                    //{
                    //    int sum = array[i] + array[j];
                    //    if (sum + array[j + 1] == x)
                    //    {
                    //        Console.WriteLine();
                    //    }
                    //    j++;
                    //}
                }
            }
        }
    }
}
