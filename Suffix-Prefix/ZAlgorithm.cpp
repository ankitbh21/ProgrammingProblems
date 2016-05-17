/**
 * Date 05/12/2016
 * @author Ankit Bhardwaj
 *
 * Z algorithm to pattern matching
 *
 * Time complexity - O(n + m)
 * Space complexity - O(n + m)
 *
 * http://www.geeksforgeeks.org/z-algorithm-linear-time-pattern-searching-algorithm/
 * http://www.utdallas.edu/~besp/demo/John2010/z-algorithm.htm
 */

#include <iostream>
#include <string>
#include <math.h>

using namespace std;

int matchingIncrementalLength(string text, int i, int j)
{
	int len = text.length();
	int matchLen = 0;
	while ( j < len && text[i] == text[j])
	{
		matchLen++;
		i++;
		j++;
	}
	return matchLen;
}

int copyZValues(string text, int* arr, int index)
{
	int len = text.length();
	int l = index;
	int r = index + arr[index];
	int i = 1;
	while(l + i <= r && r < len)
	{
		if(arr[i] + l + i < r)
		{
			arr[l + i] = arr[i];
			i++;
		}
		else
		{
			l = l + i;			
			int partialLen = matchingIncrementalLength(text, arr[i], l + arr[i]);
			arr[l] = arr[i] + partialLen;
			r = l + arr[l];
			i = 1;
		}
	}
	return r;
}

int matchingPrefixLength(string text, int* arr, int index)
{
	int i = 0;
	while(i < text.length())
	{
		if(text[i] == text[index])
		{
			index++;
			i++;
		}
		else
		{
			break;
		}
	}
	return i;
}

int* createZArray(string text)
{
	int len = text.length();
	int* arr = (int*) malloc (text.length());
	arr[0] = 0;
	for (int i = 1; i < len;)
	{
		if(arr[i-1] > 1)
		{
			i = copyZValues(text, arr, i-1);
		}
		else
		{
			arr[i] = matchingPrefixLength(text, arr, i);
			int temp = arr[i];
			i++;
		}
	}
	return arr;
}

int patternMatch(string text, string pattern)
{
	string concatenated = pattern + "$" + text;
	int* arr = createZArray(concatenated);
	int len = pattern.length();
	int textLen = concatenated.length();
	int index = len;
	while(index < textLen && arr[index] != len)
	{
		index++;
	}
	if(index == textLen)
	{
		return -1;
	}
	return (index - len - 1);
}

int main()
{	
int x=patternMatch("aaabxaabx","aabx");
	cout<<"neeraj"<<endl;
	return 0;
}
