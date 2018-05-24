using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class LargestProduct
    {
        public int FindLargestProduct(int[,] inputArray)
        {
            // Ensure that neither dimension is empty
            if (inputArray.GetLength(0) < 1 || inputArray.GetLength(1) < 1)
            {
                throw new ArgumentException("Must provide a 2D array with dimensions" +
                    "greater than 0 in length.", nameof(inputArray));
            }

            int largestProduct = 0;
            int innerProduct = 0;

            //GetLength() refers to the length of the first dimension -- rows
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                // Reset the inner product for this iteration to the first item of the
                // inner array
                innerProduct = inputArray[i, 0];

                //GetLength() refers to the length of the second dimension -- columns
                //comparing the value for the top row to the value for the bottom row
                for (int j = 1; j < inputArray.GetLength(1); j++)
                {
                    innerProduct *= inputArray[i, j];
                }

                //if innerProduct is less than largestProduct
                if (innerProduct > largestProduct)
                {
                    //leargestProduct equals innerProduct
                    largestProduct = innerProduct;
                }
            }

            Console.WriteLine(largestProduct);
            return largestProduct;
        }
    }
}
