#include<bits/stdc++.h>
#define ll long long int
using namespace std;
int main()
{
    ll n,m,k;
    cin>>n>>m>>k;
    ll ans=n*(n-1)/2;
    if(m>=n && m<=ans)
    cout<<"YES";
    else
    cout<<"NO";
    cout<<endl;
}