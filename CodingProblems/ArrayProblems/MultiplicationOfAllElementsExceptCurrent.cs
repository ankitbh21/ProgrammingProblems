using System;
using System.Collections.Generic;
using System.Text;

/*
 * Given an array of integers, return a new array such that each element at index i of the new array is the product of 
 * all the numbers in the original array except the one at i.
 * For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
 * If our input was [3, 2, 1], the expected output would be [2, 3, 6].
 * Follow-up: what if you can't use division?
 */

namespace ArrayProblems
{
    public class MultiplicationOfAllElementsExceptCurrent
    {
        public static int[] GetResult(int[] A)
        {
            var length = A.Length;
            int[] result = new int[length];
            int[] leftArray = GetLeftArrayMultiplication(A);
            int[] rightArray = GetRightArrayMultiplication(A);
            for (int i = 0; i < length; i++)
            {
                result[i] = leftArray[i] * rightArray[i];
            }
            return result;
        }

        private static int[] GetLeftArrayMultiplication(int[] A)
        {
            var length = A.Length;
            int[] result = new int[length];
            result[0] = 1;
            for (int i = 1; i < length; i++)
            {
                result[i] = result[i - 1] * A[i - 1];
            }
            return result;
        }

        private static int[] GetRightArrayMultiplication(int[] A)
        {
            var length = A.Length;
            int[] result = new int[length];
            result[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                result[i] = result[i + 1] * A[i + 1];
            }
            return result;
        }
    }
}
