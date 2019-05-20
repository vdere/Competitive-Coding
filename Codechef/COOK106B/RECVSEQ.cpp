#include<bits/stdc++.h>
using namespace std;
#define ll long long int

bool isAP(ll a[],int n){
    if (n == 1) 
    return true; 
  ll d = a[1] - a[0]; 
  for (ll i=2; i<n; i++) 
    if (a[i] - a[i-1] != d) 
      return false; 
  
  return true;
}


int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
	ll t;
	cin>>t;
	while(t--){
	    ll n;
	    cin>>n;
	    ll a[n];
	    for(ll i=0;i<n;i++){
	        cin>>a[i];
	    }
	    if(isAP(a,n)){
	        for(ll i=0;i<n;i++)
	        cout<<a[i]<<" ";
	        cout<<"\n";
	    }
	    else{
	         ll b[n-1];
	         for(ll i=1;i<n;i++)
	         b[i-1]=a[i];
	         if(isAP(b,n-1))
	         {
	             ll d=a[2]-a[1];
	             a[0]=a[1]-d;
	         }
	         else{
	             for(ll i=0;i<n-1;i++)
	             b[i]=a[i];
	             if(isAP(b,n-1))
    	         {
    	             ll d=a[1]-a[0];
    	             a[n-1]=a[n-2]+d;
    	         }
    	         else{
    	             for(ll i=1;i<n-2;i++){
    	                 if((a[i]-a[i-1])!=(a[i+1]-a[i])){
    	                     if(a[i+1]-a[i-1]==2*(a[i+2]-a[i+1]))
    	                     a[i]=a[i-1]+(a[i+2]-a[i+1]);
    	                     else{
    	                         if(a[i+2]-a[i]==2*(a[i]-a[i-1]))
    	                         a[i+1]=a[i]+(a[i]-a[i-1]);
    	                     }
    	                 }
    	             }
    	         }
	         }
	        for(ll i=0;i<n;i++)
	        cout<<a[i]<<" ";
	        cout<<"\n";
	    }
	}
	return 0;
}
