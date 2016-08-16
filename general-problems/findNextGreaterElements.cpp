#include <iostream>
#include<stdio.h>
#include<stdlib.h>
#define STACKSIZE 1000

using namespace std;

// stack structure
struct stack
{
    int top;
    int items[STACKSIZE];
    stack()
    {
    	top = -1;
	}
};
 
// Stack Functions to be used by printNGE()
void push(struct stack *ps, int x)
{
    if (ps->top == STACKSIZE-1)
    {
        cout<<"Error: stack overflow\n";
        getchar();
        exit(0);
    }
    else
    {
        (ps->top)++;
        ps->items [ps->top] = x;
    }
}
 
bool isEmpty(struct stack *ps)
{
    return (ps->top == -1)? true : false;
}
 
int pop(struct stack *ps)
{
    int temp;
    if (isEmpty(ps))
    {
        cout<<"Error: stack underflow \n";
        getchar();
        exit(0);
    }
    else
    {
        temp = ps->items[ps->top];
        (ps->top)--;
        return temp;
    }
}

int peek(struct stack *ps)
{
    int temp;
    if (isEmpty(ps))
    {
        cout<<"Error: stack underflow \n";
        getchar();
        exit(0);
    }
    else
    {
        return ps->items[ps->top];        
    }
}

void printArray(int arr[], int n)
{
    for(int i = 0; i<n; i++)
        cout<<arr[i]<<" ";
    cout<<endl;
}

void calculateNGE(int arr[], int n)
{
    int nge[STACKSIZE];
    struct stack s;
    for (int i=0; i<n; i++)
    {
    	if(!isEmpty(&s) && arr[peek(&s)] <= arr[i])
    	{
    		while(!isEmpty(&s) && arr[peek(&s)] <= arr[i])
    		{
    		    int poped = pop(&s);
    			nge[poped] = arr[i];
			}
		}
		push(&s, i);
	}
	if(!isEmpty(&s))
	{
	    while(!isEmpty(&s))
		{
			nge[pop(&s)] = -1;
		}
	}
	printArray(nge, n);
}

int main() {
	//code
	int A[1000];
	int N;
	int T;
	cin>>T;
	for (int i = 0; i<T; i++)
	{
	    cin>>N;
	    for (int j=0; j<N; j++)
	    {
	        cin>>A[j];
	    }
	    calculateNGE(A, N);
	}
	return 0;
}
