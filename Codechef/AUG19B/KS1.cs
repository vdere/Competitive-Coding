using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
	/*string line = Console.ReadLine();
		line = Console.ReadLine();
	    string[] lineSplitter = line.Split(' ');
        lineSplitter = line.Split(' ');
	    for(long i=0;i<tc;i++){
            initArr[i] = Int64.Parse(lineSplitter[i]);
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
            } 
            else {
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
	    int tc = Convert.ToInt32(Console.ReadLine());
	    while(tc-->0){
	        int i,j,k;
	        int n = Convert.ToInt32(Console.ReadLine());
	        int[] initArr = new int[n];
	        int ans=0;
	        string line = Console.ReadLine();
	        string[] lineSplitter = line.Split(' ');
	        lineSplitter = line.Split(' ');
	        for(i=0;i<n;i++){
                initArr[i] = Int32.Parse(lineSplitter[i]);
            }
            for(i=0;i<n;i++){
                for(j=0;j<n-i;j++){
                    int expon=0;
                    List<int> list22 = new List<int>();
                    for(k=i;k<n-j;k++){
                        expon^=initArr[k];
                        list22.Add(initArr[k]);
                    }
                    if(expon.Equals(0)){
                        ans+=(list22.Count-1);
                    }
                }
            }
            Console.WriteLine(ans);
	    }
	}   
}