using System;
using System.Collections.Generic;
using System.Text;

namespace SearchProblems
{
    public class SubstringSearch
    {
        #region KMP Substring Search
        public static int KMPSubstringSearch(string text, string pattern)
        {
            int textLength = text.Length;
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern)) return -1;
            int patternLength = pattern.Length;
            if (textLength < patternLength) return -1;
            if (textLength == patternLength)
            {
                return text == pattern ? 0 : -1;
            }

            var prefixLengthArray = GeneratePrefixLengthArray(pattern);
            int textCounter = 0, patternCounter = 0;
            while (textCounter < textLength)
            {
                if (text[textCounter] == pattern[patternCounter])
                {
                    textCounter++;
                    patternCounter++;
                }
                if (patternCounter == patternLength)
                {
                    return textCounter - patternCounter;
                }
                if (textCounter < textLength && text[textCounter] != pattern[patternCounter])
                {
                    if (patternCounter != 0)
                    {
                        patternCounter = prefixLengthArray[patternCounter - 1];
                    }
                    else
                    {
                        textCounter++;
                    }
                }
            }
            return -1;
        }

        private static int[] GeneratePrefixLengthArray(string pattern)
        {
            int lengthOfPattern = pattern.Length;
            var prefixLengthArray = new int[lengthOfPattern];
            prefixLengthArray[0] = 0;
            int i = 1;
            int prefixLength = 0;
            while (i < lengthOfPattern)
            {
                if (pattern[i] == pattern[prefixLength])
                {
                    prefixLength++;
                    prefixLengthArray[i] = prefixLength;
                    i++;
                }
                else
                {
                    if (prefixLength == 0)
                    {
                        prefixLengthArray[i] = 0;
                        i++;
                    }
                    else
                    {
                        prefixLength = prefixLengthArray[prefixLength - 1];
                    }
                }
            }
            return prefixLengthArray;
        }
        #endregion

        #region Rabin Karp Substring Search
        public static int RabinKarpSubstringSearch(string text, string pattern)
        {
            int textLength = text.Length;
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern)) return -1;
            int patternLength = pattern.Length;
            if (textLength < patternLength) return -1;
            ulong patternHash = 0, textHash = 0;
            double prime = 101;
            for (int i = 0; i < patternLength; i++)
            {
                patternHash += pattern[i] * (ulong)Math.Pow(prime, i);
                textHash += text[i] * (ulong)Math.Pow(prime, i);
            }
            int patternCount = 0;
            do
            {
                if (patternHash == textHash)
                {
                    return patternCount;
                }
                if (patternCount + patternLength == textLength) return -1;
                textHash -= text[patternCount];
                textHash /= (ulong)prime;
                textHash += text[patternCount + patternLength] * (ulong)Math.Pow(prime, patternLength - 1);
                patternCount++;
            } while (patternCount <= textLength + 1 - patternLength);
            return -1;
        }
        #endregion
    }
}
