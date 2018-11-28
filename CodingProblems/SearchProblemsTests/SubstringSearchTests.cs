using NUnit.Framework;
using SearchProblems;

namespace SearchProblemsTests
{
    class SubstringSearchTests
    {
        #region KMP Search Tests
        [Test]
        public void KMPSearch_ExampleTest1()
        {
            var actual = SubstringSearch.KMPSubstringSearch("bangladesh", "glade");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void KMPSearch_ExampleTest2()
        {
            var actual = SubstringSearch.KMPSubstringSearch("ABABDABACDABABCABAB", "ABABCABAB");
            Assert.AreEqual(10, actual);
        } 
        #endregion

        #region Rabin Karp Search Tests
        [Test]
        public void RabinKarpSearch_ExampleTest1()
        {
            var actual = SubstringSearch.RabinKarpSubstringSearch("bangladesh", "glade");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void RabinKarpSearch_ExampleTest2()
        {
            var actual = SubstringSearch.RabinKarpSubstringSearch("ABABDABACDABABCABAB", "ABABCABAB");
            Assert.AreEqual(10, actual);
        } 
        #endregion
    }
}
