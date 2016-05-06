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
	int arr[text.length()];
	arr[0] = 5;
	arr[1] = 3;
	return arr;
}

int patternMatch(string text, string pattern)
{
	return -1;
}

int main()
{
	int * a = createSuffixArray("hi");
	cout<<a[0]<<" "<<a[1];
	cout<<patternMatch("ankitbhardwaj", "bhard");
	return -1;
}
