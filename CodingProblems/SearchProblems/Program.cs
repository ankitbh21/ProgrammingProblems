using System;
using System.Linq;

namespace SearchProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array = new int[] { 17, 6, 100, 9, 10, 12, 3, -1, 10 };
            //var array = Enumerable.Range(0, 1000).ToArray();
            //var secondSmallest = TournamentTreeProblems.FindSecondSmallestInTournamentTree(array);
            //Console.WriteLine(secondSmallest);

            //secondSmallest = LinearSearch.FindSecondSmallestElement(array);
            //Console.WriteLine(secondSmallest);

            //int[] arr = { 0, 10, 2, -10, -20, 4 };
            //int[] arr = { 9, 1, 8, 2, 3, 7, 4, 5, 6 };
            //int arr_size = arr.Length;
            //int missing = FirstMissingIntegerInUnsortedArray.GetFirstMissingPositiveInteger(arr);
            //Console.WriteLine("The smallest positive missing number is " + missing);

            //int matchIndex = SubstringSearch.RabinKarpSubstringSearch("ABCABCA", "BCA");
            //Console.WriteLine(matchIndex);

            Trie trie = new Trie();
            
            trie.AddWord("ankit");
            trie.AddWord("ankur");
            //trie.AddWord("ank");
            trie.AddWord("ankush");
            trie.AddWord("manish");

            var res = trie.GetMatchingResults("ank");

            Console.ReadLine();
        }
    }
}
