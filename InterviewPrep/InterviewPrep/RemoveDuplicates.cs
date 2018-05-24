using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class RemoveDuplicates
    {
        //Given a string of characters, remove all duplicate characters. Return a string with the character in order of first appearance.

        public string RemoveAllDupes(string input)
        {
            //declare an empty string to store the new, modified string
            string result = "";
            //make all letters lower cased
            input.ToLower();
            //for each character in input
            foreach (char value in input)
            {
                //if result does not contain value 
                if (!result.Contains(value.ToString())) //if (result.IndexOf(value) == -1) {} would also work
                {
                    //add the value to the result string
                    result += value;
                }
            }
            Console.WriteLine(result);
            //return result
            return result;
        }
    }
}
