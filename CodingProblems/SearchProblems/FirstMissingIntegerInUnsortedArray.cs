using System;
using System.Collections.Generic;
using System.Text;

/*
 * This problem was asked by Stripe.
 * Given an array of integers, find the first missing positive integer in linear time and constant space. 
 * In other words, find the lowest positive integer that does not exist in the array. 
 * The array can contain duplicates and negative numbers as well.
 * For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
 * HINT: You can modify the input array in-place.
 */

namespace SearchProblems
{
    public class FirstMissingIntegerInUnsortedArray
    {
        public static int GetFirstMissingPositiveInteger(int[] A)
        {
            int positiveElementIndex = -1;
            int len = A.Length;
            for (int i = 0; i < len; i++)
            {
                if (A[i] > 0)
                {
                    positiveElementIndex++;
                    var temp = A[i];
                    A[i] = A[positiveElementIndex];
                    A[positiveElementIndex] = temp;
                }
            }

            if (positiveElementIndex == -1) return 1;

            for (int i = 0; i <= positiveElementIndex; i++)
            {
                var position = Math.Abs(A[i]) - 1;
                if (position < len && A[position] > 0)
                {
                    A[position] = -Math.Abs(A[position]);
                }
            }

            for (int i = 0; i <= positiveElementIndex; i++)
            {
                if (A[i] > 0) return i + 1;
            }
            return positiveElementIndex + 2;
        }
    }
}
