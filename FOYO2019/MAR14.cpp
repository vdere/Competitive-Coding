#include <iostream>
using namespace std;




int main() {
	int n;
	int array[] = {3,1,4,1,5,9,2,6,5,3,5,8,9,7,9,3,2,3,8,4,6,2,6,4,3,3,8,3,2,7};
	cin>>n;
	long long int pro = 1; 
    for (int i = 0; i < n; i++)  
        pro = pro * array[i]; 
     
	cout<<pro;    
	return 0;
}
