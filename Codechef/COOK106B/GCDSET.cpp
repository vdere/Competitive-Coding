#include <bits/stdc++.h>
using namespace std;
typedef long long ll;

int main() {
     ll t;
     cin>>t;
     while(t--){
     	ll l,r,g;
     	cin>>l>>r>>g;
     	
     	ll p = (l-1)/g;
     	ll q = r/g;
     	
     	ll ans = q-p;
		if(ans==1){
			if(g<=r&&g>=l)
			ans = 1;
			else
				ans=0; 
		}
		cout<<ans<<endl;	
    }
}