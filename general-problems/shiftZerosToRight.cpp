#include <iostream>
#include <cmath>

using namespace std;

void shiftZero(int arr[], int len)
{
    int count = 0;
    for(int i = 0; i<len; i++)
    {
        if(arr[i] != 0)
        {
            arr[count++] = arr[i];
        }
    }
    
    while(count < len)
    {
        arr[count++] = 0;
    }
}

int main() {
	// Note that size of arr[] is considered 100 according to
    // the constraints mentioned in problem statement.
    int arr[1000], t, n;
    int arrId = 0;
 
    // Input the number of test cases you want to run
    cin >> t;
 
    // One by one run for all input test cases
    while (arrId < t)
    {
        // Input the size of the array
        cin >> n;
 
        // Input the array
        for (int i=0; i<n; i++)
        {
            cin >> arr[i];
        }
        
        // Shift zeros in array
        shiftZero(arr, n);
        
        for(int i = 0; i < n ; i++)
        {
            cout<<arr[i]<<" ";
        }
        cout<<endl;
        arrId++;
    }
    return 0;
}
