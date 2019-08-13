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
        
public static class ArrayExtensions
{
    public static void Init<T>(this T[] array, T defaultVaue)
    {
        if (array == null)
            return;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = defaultVaue;
        }
    }
}        
        
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
    
    static long countBits(long n){
        if(n.Equals(0))
            return 0;
        else 
            return 1 + countBits(n & (n - 1));
    }
    
	public static void Main(){
	    long tc = Convert.ToInt64(Console.ReadLine());
	    while(tc-->0){
	        long n = Convert.ToInt64(Console.ReadLine());
	        long eternal = 0;
	        HashSet<long> set1 = new HashSet<long>();
	        HashSet<long> tempSet = new HashSet<long>();
	        for(long i=0;i<n;i++){
	            long val = Convert.ToInt64(Console.ReadLine());
	            if(!set1.Contains(val)){
	                set1.Add(val);
	                long countSetBitsMod = countBits(val)%2;
	                if(countSetBitsMod.Equals(0))
	                    eternal+=1;
	                foreach(long element in set1){
	                    if(element!=val){
	                        long result = val^element;
	                        if(!set1.Contains(result)){
	                            if(countBits(result)%2==0)
	                                eternal+=1;
	                            tempSet.Add(result);
	                        }
	                    }
	                }
	                foreach(long j in tempSet){
	                    if(!set1.Contains(j))
	                        set1.Add(j);
	                }
	                tempSet.Clear();
	                long stringCount = set1.Count;
	                Console.WriteLine(eternal + " " + (stringCount-eternal));
	            }
	            else{
	                long stringCount = set1.Count;
	                Console.WriteLine(eternal + " " + (stringCount-eternal));
	            }
	        }
	    }
	}   
}