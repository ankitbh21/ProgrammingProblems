using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems
{
    public class BinarySearchUtility
    {
        public static int BinarySearchWithLessComparision(int[] A, int key)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            int m;
            int l = 0, r = length - 1;
            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] <= key) l = m;
                else r = m;
            }

            return (A[l] == key) ? l : (A[r] == key) ? r : -1;
        }

        // Floor function
        public static int GetKeyOrFloorIndex(int[] A, int key)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            if (key < A[0]) return -1;
            if (key > A[length - 1]) return length - 1;
            int m;
            int l = 0, r = length - 1;
            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] <= key) l = m;
                else r = m;
            }

            //return (A[l] == key) ? l : (A[r] == key) ? r : l;
            return (A[r] == key) ? r : l;
        }

        // Ceiling function
        public static int GetKeyOrCeilingIndex(int[] A, int key)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            if (key < A[0]) return 0;
            if (key > A[length - 1]) return -1;
            int m;
            int l = 0, r = length - 1;
            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] >= key) r = m;
                else l = m;
            }

            return (A[l] == key) ? l : r;
        }

        public static int GetRightMostIndex(int[] A, int key)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            if (key < A[0] || key > A[length - 1]) return -1;
            if (key == A[length - 1]) return length - 1;
            int m;
            int l = 0, r = length - 1;
            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] <= key) l = m;
                else r = m;
            }

            if (A[l] == key) return l;
            return -1;
        }

        public static int GetLeftMostIndex(int[] A, int key)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            if (key < A[0] || key > A[length - 1]) return -1;
            if (key == A[0]) return 0;
            int m;
            int l = 0, r = length - 1;
            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] >= key) r = m;
                else l = m;
            }

            if (A[r] == key) return r;
            return -1;
        }

        public static int CountOccurances(int[] A, int key)
        {
            int left = GetLeftMostIndex(A, key);
            if (left == -1) return 0;
            int right = GetRightMostIndex(A, key);
            return right - left + 1;
        }

        public static int GetIndexOfRotationInSortedArray(int[] A)
        {
            if (A == null) return -1;
            int length = A.Length;
            if (length == 0) return -1;
            int l = 0, r = length - 1;
            if (A[l] < A[r]) return l;
            int m;

            while (r - l > 1)
            {
                m = (l + r) / 2;
                if (A[m] > A[r]) l = m;
                else r = m;
            }
            return r;
        }
    }
}
