using System;
using System.Collections.Generic;
using System.Text;

namespace SearchProblems
{
    public class LinearSearch
    {
        public static int FindSecondSmallestElement(int[] A)
        {
            int comparision = 0;
            int length = A.Length;
            if (length < 2) return (length == 1) ? A[0] : throw new ArgumentException();
            int smallest = int.MaxValue, secondSmallest = int.MaxValue - 1;
            for (int i = 0; i < length; i++)
            {
                if (A[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = A[i];
                    comparision += 1;
                }
                else if (A[i] < secondSmallest)
                {
                    secondSmallest = A[i];
                    comparision += 2;
                }
                else comparision += 2;
            }
            Console.WriteLine($"Comparision: {comparision}");
            return secondSmallest;
        }
    }
}
