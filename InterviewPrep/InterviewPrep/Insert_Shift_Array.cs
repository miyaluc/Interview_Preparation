using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    //Write a function called InsertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.
    class Insert_Shift_Array
    {
        public int[] ShiftArray(int[] array, int value)
        {
            //setting up a new int array with extra space for insertion of a new value
            int[] newArray = new int[array.Length + 1];
            //finding the midpoint because this is where a new number will be inserted
            int midPoint = array.Length / 2;
            //implementing for loop
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < midPoint)
                {
                    newArray[i] = array[i];
                }
                if (i == midPoint)
                {
                    //insert value here
                    newArray[i] = value;
                    //shift newArray by one - 
                    newArray[i + 1] = array[i];
                }
                if (i > midPoint)
                {
                    //contnue to add the rest of the integers in array
                    newArray[i + 1] = array[i];
                }
            }
            Console.WriteLine($"Take a look at your new array. {value} has been added:");

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);

            }
            return newArray;
        }
    }
}
