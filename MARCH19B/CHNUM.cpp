#include<bits/stdc++.h>
using namespace std;

int main()
{
	int tc,n,largest,smallest,var;
    cin>>tc;
    while(tc--)
    {
        largest=smallest=0;
        cin>>n;
        for(int i=0;i<n;i++)
        {
            cin>>var;
            if(var<0)
                smallest++;
            else
                largest++;
        }
        if(largest==n || smallest==n){
            cout<<n<<" "<<n<<"\n";
        } 
        else if(largest>=smallest){
            cout<<largest<<" "<<smallest<<"\n";
        } 
        else 
            cout<<smallest<<" "<<largest<<"\n";
    }
	return 0;
}