using NUnit.Framework;
using SearchProblems;

namespace Tests
{
    public class FirstMissingIntegerInUnsortedArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExampleTest1()
        {
            int[] A = { 1, 2, 0 };
            Assert.AreEqual(3, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ExampleTest2()
        {
            int[] A = { 3, 4, -1, 1 };
            Assert.AreEqual(2, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassTheForAllNonPositives()
        {
            int[] A = { -3, -1, -2 };
            Assert.AreEqual(1, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForAllPositives()
        {
            int[] A = { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(7, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForAllZeros()
        {
            int[] A = { 0, 0, 0, 0, 0 };
            Assert.AreEqual(1, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForAllPositivesUnsorted()
        {
            int[] A = { 9, 1, 8, 2, 3, 7, 4, 5, 6 };
            Assert.AreEqual(10, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForAllPositivesUnsortedMissingInMid()
        {
            int[] A = { 9, 1, 8, 2, 3, 4, 5, 6 };
            Assert.AreEqual(7, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForRandomPositiveSequenceStartingFrom1()
        {
            int[] A = { 9, 8, 3, 4, 1, 5, 6 };
            Assert.AreEqual(2, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForRandomPositiveSequenceStartingFrom2()
        {
            int[] A = { 9, 8, 2, 3, 4, 5, 6 };
            Assert.AreEqual(1, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForRandomPositiveSequenceStartingFrom3()
        {
            int[] A = { 9, 8, 4, 5, 6 };
            Assert.AreEqual(1, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForRandomMixedSequenceStartingWithout1()
        {
            int[] A = { -1, -2, 9, 8, -2, 4, 5, 6 };
            Assert.AreEqual(1, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }

        [Test]
        public void ShouldPassForRandomMixedSequenceStartingWith1()
        {
            int[] A = { -1, -2, 9, 8, -2, 4, 5, 6, 1 };
            Assert.AreEqual(2, FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(A));
        }
    }
}