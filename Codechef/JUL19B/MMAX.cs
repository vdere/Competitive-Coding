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
    

    static void Swap<T>(ref T lhs, ref T rhs){
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
    
    static long gcdEuclid(long answer, long b){
        if (answer == 0) 
            return b; 
        return gcdEuclid(b % answer, answer); 
    }
    
	public static void Main()
	{
	    long tc = Convert.ToInt64(Console.ReadLine());
	    while(tc-->0){
	        long n = Convert.ToInt64(Console.ReadLine());
	        long k = Convert.ToInt64(Console.ReadLine());
	        long r = k%n;
	        long d = n-r;
	        if(r.Equals(0)){
	            Console.WriteLine(0);
	        }
	        else if(n>=2*r+1){
	            Console.WriteLine(2*r);
	        }
	        else if(n.Equals(2*r)){
	            Console.WriteLine(2*r-1);
	        }
	        else if(n<2*r){
	            Console.WriteLine(2*d);
	        }
	    }
	}   
}