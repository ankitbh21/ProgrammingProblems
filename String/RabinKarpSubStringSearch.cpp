/**
 * Date 04/05/2016
 * @author ankitbh21
 *
 * Rabin Karp algorith for substring matching.
 *
 * Time complexity in worst case O(n^2)(depends on hash function)
 * Space complexity O(1)
 *
 * References
 * https://en.wikipedia.org/wiki/Rabin%E2%80%93Karp_algorithm
 */

#include <iostream>
#include <string>
#include <math.h>

using namespace std;

int prime = 101;

// Focus on long long datatype
long long rollingHash(string text, int oldIndex, int newIndex, long long hash, int len)
{
	long long newHash = hash - text[oldIndex];
	newHash /= prime;
	newHash += text[newIndex] * pow(prime, len - 1);
	return newHash;
}

long long createHash(string text, int len)
{
	long long hash = 0;
	for(int i=0; i<len; i++)
	{
		hash += text[i] * pow(prime, i);
	}
	return hash;
}

bool compareText(string text, int start, int end, string pattern)
{
	int i = 0;	
	while(start <= end)
	{
		if(text[start] == pattern[i])
		{
			start++;
			i++;
		}
		else
		{
			return false;
		}
	}
	return true;
}

int patternMatch(string text, string pattern)
{
	int textLen = text.length();
	int patternLen = pattern.length();
	long long patternHash = createHash(pattern, patternLen);
	long long textHash = createHash(text, patternLen);
	for(int i = 1; i <= textLen - patternLen + 1; i++)
	{
		if(patternHash == textHash)
		{
			if(compareText(text, i-1, i+patternLen-2, pattern))
			{
				return i - 1;
			}
		}
		
		if(i < textLen - patternLen + 1)
		{
			// remember i-1 and i+patternLen-1
			textHash = rollingHash(text, i - 1, i + patternLen - 1, textHash, patternLen);
		}		
	}
	return -1;
}

int main()
{
	cout<<patternMatch("ankitbhardwaj","bhard")<<endl;
	cout<<patternMatch("ankitbhardwaj","hard")<<endl;
	cout<<patternMatch("ankitbhardwaj","ahard")<<endl;
	cout<<patternMatch("ankitbhardwaj","hardwaj")<<endl;
	cout<<patternMatch("ankitbhardwaj","ank")<<endl;
	return 0;
}

