using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Fibonacci_Sequence
    {
        public int RecursiveFibonacci(int n)
        {
            //base case
            if (n <= 1)
            {
                return 0;
            }
            //else
            return RecursiveFibonacci(n-1) + RecursiveFibonacci(n-2);
        }

        public int IterativeFibonacci(int n)
        {
            //need three ints a, b, and c to keep track of changing values as n increases
            int a = 0;
            int b = 1;
            int c = 0;
            //tracker will keep track of each round 
            int tracker = 1;

            Console.WriteLine("round 1: " + c);

            //while tracker is less than or equal to n
            while (tracker <= n)
            {
                c = a + b;
                //output current round and current sum
                Console.WriteLine($"{tracker}: {c}");
                //a equals b
                a = b;
                //b equals c
                b = c;
                //increment tracker for while loop
                tracker++;
            }
            return 0;
        }
    }
}
