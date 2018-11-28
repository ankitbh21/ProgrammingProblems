using ArrayProblems;
using NUnit.Framework;

namespace ArrayProblemsTests
{
    public class MultiplicationOfAllElementsExceptCurrentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExampleTest1()
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] expected = { 120, 60, 40, 30, 24 };
            var actual = MultiplicationOfAllElementsExceptCurrent.GetResult(A);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest2()
        {
            int[] A = { 3, 2, 1 };
            int[] expected = { 2, 3, 6 };
            var actual = MultiplicationOfAllElementsExceptCurrent.GetResult(A);
            Assert.AreEqual(expected, actual);
        }
    }
}