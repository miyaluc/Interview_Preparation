using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class String_Compression
    {
        //Implement a method to perform basic string compression using the counts of repeated characters. If the "compressed" string is not smaller than the original string, your method should return the original string.
        
        public string Compress(string input)
        {
            //instantiate StringBuilder sb
            StringBuilder sb = new StringBuilder();

            //declare int variable countConsecutive
            int countConsecutive = 0;

            //implement for loop with length of input using int i
            for (int i = 0; i < input.Length; i++)
            {
                //increment countConsecutive
                countConsecutive++;

                //if next value is greater than / equal to input length OR if the next value is different than current
                if (i + 1 >= input.Length || input[i + 1] != input[i])
                {
                    //append input at i to sb
                    sb.Append(input[i]);
                    //append countConsecutive to sb
                    sb.Append(countConsecutive);
                    //set countConsecutive to 0 to prepare for next value
                    countConsecutive = 0;
                }
            }
            //if length of sb is less than length of input, output sb and return sb
            if (sb.Length <= input.Length)
            {
                Console.WriteLine(sb.ToString());
                return sb.ToString();
            }
            //output original input
            Console.WriteLine(input);
            return input;
        }
    }
}
