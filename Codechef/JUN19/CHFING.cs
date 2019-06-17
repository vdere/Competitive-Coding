using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
	/*string line = Console.ReadLine();
		line = Console.ReadLine();
	    string[] lineSplitter = line.Split(' ');
        lineSplitter = line.Split(' ');
	    for(long i=0;i<tc;i++){
            arr[i] = Int64.Parse(lineSplitter[i]);
        }*/
public class Test
{
    static long mod = 1000000007;
    
    static long substr(long n,string s,char c){
        long x1=0,x2=0,y1=0,y2=0;
        //char indexofString = Char.Parse(s[0]);
        if(s[0] == c)
            x1 = 1;
        for(int i=1;i<s.Length;i++){
            //char indexAti = Char.Parse(s[i]);
            if(s[i] == c){
                x2 = i+1;
            }
            else{
                x2 = x1;
            }
            y2 = x1 + y1;
            x1 = x2;
            y1 = y2;
        }
        long cx = x1 + y1;
        //Console.WriteLine(x1+y1);
        return cx;
    }
    
    static void insertionElement(List<int> array, int item) {
    int beginIndex = 0;
    int endIndex = array.Count - 1;
    
    int middle = 0;
    while (endIndex - beginIndex > 0) {
      middle = (beginIndex + endIndex) / 2;
      if (array.ElementAt(middle) > item) {
        endIndex = middle;
      } else {
        beginIndex = middle + 1;
      }
    }
    
    if (array.Count > beginIndex && array.ElementAt(beginIndex) < item) beginIndex++;
    array.Insert(beginIndex, item);
  }
  
    static void daviddobrik(long hesp,long ekso){
        hesp = ekso+hesp-1;
        long result = 0,n=0;
	    long a = 2*ekso-hesp-1;
	    long d = hesp-ekso;
        if(a>0){
            n = a/d+1;
            long ludolu = a-((n-1)*d);
            if(n%2==0){
                n=n/2;
                result = (n%mod)*((a+ludolu)%mod);
            }
            else{
                a = (a+ludolu)/2;
                result = (n%mod)*((a)%mod);
            }
            result = result%mod;
        }
        long epper = result+ekso-1;
	    Console.WriteLine((epper)%mod);
    }
    
    
	public static void Main()
	{
	    long tc = Convert.ToInt64(Console.ReadLine());
	    while(tc-->0){
	        string line = Console.ReadLine();
	        string[] lineSplitter = line.Split(' ');
	        long hesp = long.Parse(lineSplitter[0]);
	        long ekso = long.Parse(lineSplitter[1]);
	        daviddobrik(hesp,ekso);
	    }
	}   
}