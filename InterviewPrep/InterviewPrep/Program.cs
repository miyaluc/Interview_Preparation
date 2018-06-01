using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Watch me reverse the numbers.");

            //Array_Reversal ara = new Array_Reversal();
            //int[] input = { 4, 8, 15, 16, 23, 42 };
            //ara.Reverse(input);
            //Console.ReadLine();

            //Console.WriteLine("Below is a more efficient way of reversing an array. Forgive the duplicates.");
            //Reverse(input);
            //Console.ReadKey();
            //Console.Clear();

            //int[] input2 = {6, 4, 8, 2, 4, 9};
            //Console.WriteLine("Below is an array that will be shifted after I insert a new number.");
            //for (int x = 0; x < input2.Length; x++)
            //{
            //    Console.WriteLine(input2[x]);
            //}
            //Insert_Shift_Array test = new Insert_Shift_Array();
            //test.ShiftArray(input2, 3);

            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine($"Here is my Binary Search demonstration for the previously reversed array:");
            //Binary_Search bs = new Binary_Search();
            //bs.BinarySearch(input, 23);
            //Console.ReadKey();
            //bs.BinarySearch(input, 3);
            //Console.ReadKey();

            //SumFinder sf = new SumFinder();
            //int[] array = { 0, 2, 8, 7, 1, -5 };
            //int[] array2 = { 14, 12, 10, 2 };
            //int[] array3 = { -3, 4, 7, 16, -7 };
            //int x = 0;
            //sf.FindSumPair(array, x);
            //sf.FindSumPair(array2, x);
            //sf.FindSumPair(array3, x);
            //Console.ReadLine();

            //sf.FindNumPairs(array, x);
            //sf.FindNumPairs(array2, x);
            //sf.FindNumPairs(array3, x);
            //Console.ReadLine();

            //sf.FindAllCombos(array, x);
            //sf.FindAllCombos(array2, x);
            //sf.FindAllCombos(array3, x);
            //Console.ReadLine();

            //Coin_Change cc = new Coin_Change();
            //int[] coins = { 1, 10, 25 };
            //cc.CoinChange(coins, 30);
            //Console.ReadLine();

            //LargestProduct lc = new LargestProduct();
            //int[,] testArray = { {1,5}, {2,3 }, {3,6 }  };
            //lc.FindLargestProduct(testArray);
            //Console.ReadLine();

            //StringCompression sbPlay = new StringCompression();
            //sbPlay.Compress("pupppyyyy");
            //sbPlay.Compress("broken");
            //Console.ReadKey();

            //Fibonacci_Sequence fibby = new Fibonacci_Sequence();
            //Console.WriteLine("Demonstrating recursive Fibonacci solution.");
            //fibby.RecursiveFibonacci(7);
            //Console.WriteLine("Demonstrating iterative Fibonacci solution.");
            //fibby.IterativeFibonacci(7);

            int[] deck = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,  44, 45, 46, 47, 48, 9, 50, 51};

            CardShark sharky = new CardShark();
            sharky.ShuffleCards(deck, 52);

            foreach(int card in deck) 
            {
                Console.WriteLine(card);
            }
            Console.ReadLine();
        }
    }
}
