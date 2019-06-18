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
  
    static long daviddobrik(long a,long b){
        long tesla = a * a;
        if (b == 0)
            return 1;
        if ((b & 1)!=0)
            return (a*daviddobrik((tesla)%mod,b/2))%mod;
        return (daviddobrik((tesla)%mod,b/2));
    }
    
	public static void Main()
	{
	    long tc = Convert.ToInt64(Console.ReadLine());
	    while(tc-->0){
	        long b = Convert.ToInt64(Console.ReadLine());
            long results = daviddobrik(2,b-1);
            Console.WriteLine((results*10)%mod);
	    }
	}   
}