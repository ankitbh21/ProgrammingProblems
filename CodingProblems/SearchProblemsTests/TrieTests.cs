using NUnit.Framework;
using SearchProblems;
using System.Collections.Generic;

namespace SearchProblemsTests
{
    class TrieTests
    {
        [Test]
        public void ShouldReturnTheStringStartingWithThePhrase()
        {
            Trie trie = new Trie();
            List<string> list = new List<string>() { "ankit", "ankur", "ank", "ankush", "manish" };
            trie.AddWords(list);
            List<string> expected = new List<string>() { "ankur", "ankush" };
            var actual = trie.GetMatchingResults("anku");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnTheStringIncludingThePhraseBeingSearched()
        {
            Trie trie = new Trie();
            List<string> list = new List<string>() { "ankit", "ankur", "ank", "ankush", "manish" };
            trie.AddWords(list);
            List<string> expected = new List<string>() { "ank", "ankit", "ankur", "ankush" };
            var actual = trie.GetMatchingResults("ank");
            Assert.AreEqual(expected, actual);
        }
    }
}
