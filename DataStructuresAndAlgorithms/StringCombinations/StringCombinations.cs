using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCombinations
{
    class StringCombinations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a text");
            string str = Console.ReadLine();
            Combine(str.ToCharArray());
            Console.ReadLine();
        }

        static void Combine(char[] input)
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
            CombineRecur(chars, count, 0, result, 0);
        }

        static void CombineRecur(char[] input, int[] characterCountInInput, int position, char[] output, int length)
        {
            ProcessResult(output, length);
            for (int i = position; i < input.Length; i++)
            {
                if (characterCountInInput[i] == 0)
                {
                    continue;
                }
                characterCountInInput[i]--;
                output[length] = input[i];
                
                CombineRecur(input, characterCountInInput, i, output, length + 1);
                characterCountInInput[i]++;
            }
        }

        private static void ProcessResult(char[] result, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
