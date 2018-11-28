using BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchProblemsTests
{
    [TestClass]
    public class BinarySearchUtilityTest
    {
        [TestMethod]
        public void BinarySearchWithLessComparisionTest()
        {
            int[] A = new int[] { -1, 2, 3, 5, 6, 8, 9, 10 };
            Assert.AreEqual(-1, BinarySearchUtility.BinarySearchWithLessComparision(A, -7));
            Assert.AreEqual(0, BinarySearchUtility.BinarySearchWithLessComparision(A, -1));
            Assert.AreEqual(-1, BinarySearchUtility.BinarySearchWithLessComparision(A, 1));
            Assert.AreEqual(2, BinarySearchUtility.BinarySearchWithLessComparision(A, 3));
            Assert.AreEqual(4, BinarySearchUtility.BinarySearchWithLessComparision(A, 6));
            Assert.AreEqual(-1, BinarySearchUtility.BinarySearchWithLessComparision(A, 7));
            Assert.AreEqual(7, BinarySearchUtility.BinarySearchWithLessComparision(A, 10));
            Assert.AreEqual(-1, BinarySearchUtility.BinarySearchWithLessComparision(A, 11));
        }

        [TestMethod]
        public void GetKeyOrFloorIndexTest()
        {
            int[] A = new int[] { -1, 2, 3, 5, 6, 8, 9, 10 };
            Assert.AreEqual(-1, BinarySearchUtility.GetKeyOrFloorIndex(A, -7));
            Assert.AreEqual(0, BinarySearchUtility.GetKeyOrFloorIndex(A, -1));
            Assert.AreEqual(0, BinarySearchUtility.GetKeyOrFloorIndex(A, 1));
            Assert.AreEqual(2, BinarySearchUtility.GetKeyOrFloorIndex(A, 3));
            Assert.AreEqual(4, BinarySearchUtility.GetKeyOrFloorIndex(A, 6));
            Assert.AreEqual(4, BinarySearchUtility.GetKeyOrFloorIndex(A, 7));
            Assert.AreEqual(7, BinarySearchUtility.GetKeyOrFloorIndex(A, 10));
            Assert.AreEqual(7, BinarySearchUtility.GetKeyOrFloorIndex(A, 11));
        }

        [TestMethod]
        public void GetKeyOrCeilingIndexTest()
        {
            int[] A = new int[] { -1, 2, 3, 5, 6, 8, 9, 10 };
            Assert.AreEqual(0, BinarySearchUtility.GetKeyOrCeilingIndex(A, -7));
            Assert.AreEqual(0, BinarySearchUtility.GetKeyOrCeilingIndex(A, -1));
            Assert.AreEqual(1, BinarySearchUtility.GetKeyOrCeilingIndex(A, 1));
            Assert.AreEqual(2, BinarySearchUtility.GetKeyOrCeilingIndex(A, 3));
            Assert.AreEqual(4, BinarySearchUtility.GetKeyOrCeilingIndex(A, 6));
            Assert.AreEqual(5, BinarySearchUtility.GetKeyOrCeilingIndex(A, 7));
            Assert.AreEqual(7, BinarySearchUtility.GetKeyOrCeilingIndex(A, 10));
            Assert.AreEqual(-1, BinarySearchUtility.GetKeyOrCeilingIndex(A, 11));
        }

        [TestMethod]
        public void GetRightMostIndexTest()
        {
            int[] A = new int[] { -1, -1, 3, 5, 5, 5, 10, 10 };
            Assert.AreEqual(-1, BinarySearchUtility.GetRightMostIndex(A, -7));
            Assert.AreEqual(1, BinarySearchUtility.GetRightMostIndex(A, -1));
            Assert.AreEqual(-1, BinarySearchUtility.GetRightMostIndex(A, 1));
            Assert.AreEqual(2, BinarySearchUtility.GetRightMostIndex(A, 3));
            Assert.AreEqual(5, BinarySearchUtility.GetRightMostIndex(A, 5));
            Assert.AreEqual(-1, BinarySearchUtility.GetRightMostIndex(A, 7));
            Assert.AreEqual(7, BinarySearchUtility.GetRightMostIndex(A, 10));
            Assert.AreEqual(-1, BinarySearchUtility.GetRightMostIndex(A, 11));
        }

        [TestMethod]
        public void GetLeftMostIndexTest()
        {
            int[] A = new int[] { -1, -1, 3, 5, 5, 5, 10, 10 };
            Assert.AreEqual(-1, BinarySearchUtility.GetLeftMostIndex(A, -7));
            Assert.AreEqual(0, BinarySearchUtility.GetLeftMostIndex(A, -1));
            Assert.AreEqual(-1, BinarySearchUtility.GetLeftMostIndex(A, 1));
            Assert.AreEqual(2, BinarySearchUtility.GetLeftMostIndex(A, 3));
            Assert.AreEqual(3, BinarySearchUtility.GetLeftMostIndex(A, 5));
            Assert.AreEqual(-1, BinarySearchUtility.GetLeftMostIndex(A, 7));
            Assert.AreEqual(6, BinarySearchUtility.GetLeftMostIndex(A, 10));
            Assert.AreEqual(-1, BinarySearchUtility.GetLeftMostIndex(A, 11));
        }

        [TestMethod]
        public void CountOccurancesTest()
        {
            int[] A = new int[] { -1, -1, 3, 5, 5, 5, 10, 10 };
            Assert.AreEqual(0, BinarySearchUtility.CountOccurances(A, -7));
            Assert.AreEqual(2, BinarySearchUtility.CountOccurances(A, -1));
            Assert.AreEqual(0, BinarySearchUtility.CountOccurances(A, 1));
            Assert.AreEqual(1, BinarySearchUtility.CountOccurances(A, 3));
            Assert.AreEqual(3, BinarySearchUtility.CountOccurances(A, 5));
            Assert.AreEqual(0, BinarySearchUtility.CountOccurances(A, 7));
            Assert.AreEqual(2, BinarySearchUtility.CountOccurances(A, 10));
            Assert.AreEqual(0, BinarySearchUtility.CountOccurances(A, 11));
        }

        [TestMethod]
        public void GetIndexOfRotationInSortedArrayTest()
        {
            int[] A = new int[] { -1, 2, 3, 5, 6, 8, 9, 10 };
            Assert.AreEqual(0, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 10, -1, 2, 3, 5, 6, 8, 9 };
            Assert.AreEqual(1, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 9, 10, -1, 2, 3, 5, 6, 8 };
            Assert.AreEqual(2, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 8, 9, 10, -1, 2, 3, 5, 6 };
            Assert.AreEqual(3, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 6, 8, 9, 10, -1, 2, 3, 5 };
            Assert.AreEqual(4, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 5, 6, 8, 9, 10, -1, 2, 3 };
            Assert.AreEqual(5, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 3, 5, 6, 8, 9, 10, -1, 2 };
            Assert.AreEqual(6, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
            A = new int[] { 2, 3, 5, 6, 8, 9, 10, -1 };
            Assert.AreEqual(7, BinarySearchUtility.GetIndexOfRotationInSortedArray(A));
        }
    }
}
