/**
 * Date 05/05/2016
 * @author ankitbh21
 * 
 * Do pattern matching using KMP algorithm
 * 
 * Runtime complexity - O(m + n) where m is length of text and n is length of pattern
 * Space complexity - O(n)
 */

#include <iostream>
#include <string>
#include <math.h>

using namespace std;

int * createSuffixArray(string text)
{
	int* arr = (int*) malloc (text.length());
	*(arr) = 0;
	int j = 0;
	int i = 1;
	for(int itr = 1; itr < text.length();)
	{
		if(text[i] == text[j])
		{
			*(arr + itr) = j + 1;
			i++;
			j++;
			itr++;
		}
		else
		{
			if(j > 0)
			{
				j = arr[j-1];
			}
			else
			{
				*(arr + itr) = 0;
				i++;
				itr++;
			}
		}
	}
	return arr;
}

int patternMatch(string text, string pattern)
{
	int* arr = createSuffixArray("abcabe");
	int textIndex = 0;
	int patternIndex = 0;
	int patternLen = pattern.length();
	while(textIndex < text.length() && patternIndex < patternLen)
	{
		if(text[textIndex] == pattern[patternIndex])
		{
			textIndex++;
			patternIndex++;
			if(patternIndex == patternLen)
			{
				return textIndex - patternLen;
			}
		}
		else
		{
			if(patternIndex == 0)
			{
				textIndex++;
			}
			else
			{
				patternIndex = arr[patternIndex - 1];
			}
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
