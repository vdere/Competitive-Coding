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
    
	public static void Main()
	{
	    int n;
	    int tc = Convert.ToInt32(Console.ReadLine());
	    while(tc-->0){
	        n = Convert.ToInt32(Console.ReadLine());
	        int flag = 1;
	        int[] caves = new int[n];
	        int[] health_lvels = new int[n];
	        int[] resultingArr = new int[n];
	        
	        //Reading caves
	        string line = Console.ReadLine();
	        string[] lineSplitter = line.Split(' ');
	        for(int i=0;i<n;i++)
	            caves[i] = int.Parse(lineSplitter[i]);
	            
	        //reading health levels
	        line = Console.ReadLine();
	        lineSplitter = line.Split(' ');
	        for(int i=0;i<n;i++)
	            health_lvels[i] = int.Parse(lineSplitter[i]); 
	            
	            
	        for(int i=0;i<n;i++){
	            int iminuscofi = i-caves[i];
	            int ipluscofi = i+caves[i];
    		    if(iminuscofi<0) 
    		        resultingArr[0]++;
    		    else 
    		        resultingArr[iminuscofi]++;
    	        if(ipluscofi<n-1) 
    	            resultingArr[ipluscofi+1]--;
	        }
	        for(int i=1;i<n;i++)
    		    resultingArr[i]+=resultingArr[i-1];
    		    
    		Array.Sort(resultingArr);Array.Sort(health_lvels);
    		
    		
    		for(int i=0;i<n;i++)
    		    if(!resultingArr[i].Equals(health_lvels[i])){
    			    flag--;
    			    break;
    		    }
    	        if(flag.Equals(1)) 
    	            Console.WriteLine("YES");
    	        else 
    	            Console.WriteLine("NO");
	    }
	}   
}