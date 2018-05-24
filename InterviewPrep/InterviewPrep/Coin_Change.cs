using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Coin_Change
    {
        public void CoinChange(int[] array, int input)
        {
            while (input > 0)
            {
                Console.WriteLine("Looking for : " + input);
                int i = 0;
                //while array at i is less than input
                while (array[i] <= input)
                {
                    //increment i
                    Console.WriteLine(array[i]+" at arr["+i+"] is less than "+input);
                    i++;
                    if (i >= array.Length)
                        break;
                }
                //output array at i
                Console.WriteLine(array[i-1]);
                //subtract array at i from input
                input -= array[i-1];
            }
        }
    }
}
