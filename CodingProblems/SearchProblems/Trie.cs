using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SearchProblems
{
    public class Trie
    {
        private TrieNode Start { get; set; }

        public Trie()
        {
            Start = new TrieNode(' ');
        }

        public bool AddWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            var node = Start;
            foreach (char c in word)
            {
                node = node.SearchOrAddChildNode(c);
            }
            node.MarkAsLastChar();
            return true;
        }

        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            var node = Start;
            foreach (char c in word)
            {
                if (node == null) return false;
                node = node.SearchChildNode(c);
            }
            if (node == null) return false;
            if (node.LastCharOfWord) return true;
            return false;
        }

        public List<string> GetMatchingResults(string word)
        {
            if (string.IsNullOrEmpty(word)) return null;
            var node = Start;
            foreach (char c in word)
            {
                if (node == null) return null;
                node = node.SearchChildNode(c);
            }
            if (node == null) return null;
            return node.GetAllChildStrings(word, false);
        }

        internal class TrieNode
        {
            //public int ChildCount { get; private set; }
            public char Data { get; private set; }
            public bool LastCharOfWord { get; private set; }

            private List<TrieNode> childNodes;

            public TrieNode(char data)
            {
                Data = data;
                //ChildCount = 0;
                LastCharOfWord = false;
                childNodes = new List<TrieNode>();
            }

            public bool AddChildNode(char c)
            {
                if (childNodes.Any(e => e.Data == c))
                {
                    return false;
                }
                CreateAndAddChildNode(c);
                return true;
            }

            public void MarkAsLastChar()
            {
                LastCharOfWord = true;
            }

            public TrieNode SearchChildNode(char c)
            {
                return childNodes.FirstOrDefault(e => e.Data == c);
            }

            public TrieNode SearchOrAddChildNode(char c)
            {
                var node = SearchChildNode(c);
                if (node == null)
                {
                    node = CreateAndAddChildNode(c);
                }
                return node;
            }

            public List<string> GetAllChildStrings(string prefixString = null, bool prependSelf = true)
            {
                List<string> allChildStrings = new List<string>();
                string newPrefixString = string.IsNullOrEmpty(prefixString) ?
                    Data.ToString() : prependSelf ? $"{prefixString}{Data.ToString()}" : prefixString;
                if (LastCharOfWord)
                {
                    allChildStrings.Add(newPrefixString);
                }
                foreach (var child in childNodes)
                {
                    allChildStrings.AddRange(child.GetAllChildStrings(newPrefixString));
                }
                return allChildStrings;
            }

            private TrieNode CreateAndAddChildNode(char data)
            {
                TrieNode node = new TrieNode(data);
                childNodes.Add(node);
                //ChildCount++;
                return node;
            }
        }
    }
}
