/**
 * Date 05/12/2016
 * @author Ankit Bhardwaj
 *
 * Generate all permutations of string in lexicographically sorted order where repetitions of
 * character is possible in string.
 * 
 * Time complexity - n!
 * Space complexity - ?
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutation
{
    class StringPermutation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a text");
            string str = Console.ReadLine();
            Permute(str.ToCharArray());
            Console.ReadLine();
        }

        static void Permute(char[] input)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();
            foreach (char item in input)
            {
                if (countMap.ContainsKey(item))
                {
                    countMap[item] = countMap[item] + 1;
                }
                else
                {
                    countMap.Add(item, 1);
                }
            }

            char[] chars = new char[countMap.Count];
            int[] count = new int[countMap.Count];
            int index = 0;
            foreach (var item in countMap)
            {
                chars[index] = item.Key;
                count[index] = item.Value;
                index++;
            }
            //char[] chars = countMap.Keys.ToArray();
            //int[] count = countMap.Values.ToArray();

            char[] result = new char[input.Length];
            PermuteRecur(chars, count, result, 0);
        }

        static void PermuteRecur(char[] str, int[] count, char[] result, int level)
        {
            if (level == result.Length)
            {
                ProcessResult(result);
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (count[i] == 0)
                {
                    continue;
                }
                count[i]--;
                result[level] = str[i];
                PermuteRecur(str, count, result, level + 1);
                count[i]++;
            }
        }

        private static void ProcessResult(char[] result)
        {
            Console.WriteLine(result);
        }
    }    
}
