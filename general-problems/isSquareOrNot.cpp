#include <iostream>
using namespace std;

// Structure of a point in 2D space
struct Point
{
    double x, y;
};
 
// A utility function to find square of distance
// from point 'p' to poitn 'q'
double distSq(Point p, Point q)
{
    return (p.x - q.x)*(p.x - q.x) +
           (p.y - q.y)*(p.y - q.y);
}

bool isSquare(Point p1, Point p2, Point p3, Point p4)
{
    double d1, d2, d3;
	d1 = distSq(p1, p2);
	d2 = distSq(p1, p3);
	d3 = distSq(p1, p4);
	
	if(d1 == d2 && 2*d1 == d3)
	{
	    int d = distSq(p2, p3);
	    return(d == d3 && d1 == distSq(p3, p4));
	}
	
	if(d2 == d3 && 2*d2 == d1)
	{
	    int d = distSq(p3, p4);
	    return(d == d1 && d2 == distSq(p2, p4));
	}
	
	if(d3 == d1 && 2*d3 == d2)
	{
	    int d = distSq(p4, p2);
	    return(d == d2 && d3 == distSq(p2, p3));
	}
	
	return false;
}

int main() {
    int t;
    cin>>t;
	while(t--)
	{
    	Point p1,p2,p3,p4;
    	cin>>p1.x>>p1.y;
    	cin>>p2.x>>p2.y;
    	cin>>p3.x>>p3.y;
    	cin>>p4.x>>p4.y;
    	
    	if(isSquare(p1, p2, p3, p4))
    	{
    	    cout<<"Yes";
    	}
    	else
    	{
    	    cout<<"No";
    	}
    	cout<<endl;
	}
	return 0;
}
