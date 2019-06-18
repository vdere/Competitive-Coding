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
    
    static void daviddobrik(long[] lefthalf,long[] answer,long[] righthalf,int jemeter,long __jmaxVal,long finalVal){
            jemeter--;
            lefthalf[0]=-1;
            righthalf[jemeter+1]=-1;
            lefthalf[1]=answer[1];
            righthalf[jemeter]=answer[jemeter];
            
            for(int i=2;i<=jemeter;i++){
                lefthalf[i]=gcdEuclid(lefthalf[i-1],answer[i]);
            }
            
            for(int i=jemeter-1;i>=1;i--){
                righthalf[i]=gcdEuclid(righthalf[i+1],answer[i]);
            }
        
            for(int i=2;i<jemeter;i++){
                finalVal=gcdEuclid(lefthalf[i-1],righthalf[i+1]) + answer[i];
                __jmaxVal=Math.Max(__jmaxVal,finalVal);
            }
            
            if(lefthalf[0]==-1 && righthalf[2]==-1){
                __jmaxVal=Math.Max(__jmaxVal,2*answer[0]);
            }
            else{
                __jmaxVal=Math.Max(__jmaxVal,answer[1]+righthalf[2]);
                __jmaxVal=Math.Max(__jmaxVal,answer[jemeter]+lefthalf[jemeter-1]);
            }
        
            if(jemeter==1){
                __jmaxVal=Math.Max(__jmaxVal,2*answer[1]);
            }
            Console.WriteLine(__jmaxVal);
    }
    
	public static void Main(){
	    long def,n,valueSortedSet,finalVal=0,__jmaxVal=-1;
	    long[] answer = new long[100009];
	    long[] lefthalf = new long[100009];
	    long[] righthalf = new long[100009];
	    SortedSet<long> setSorted = new SortedSet<long>();
	    int tc = Convert.ToInt32(Console.ReadLine());
	    
	    while(tc-->0){
	        setSorted.Clear();
	        int jemeter=1;
	        __jmaxVal = -1;
            n = Convert.ToInt64(Console.ReadLine());
            string line = Console.ReadLine();
            string[] lineSplitter = line.Split(' ');
            lineSplitter = line.Split(' ');
	        for(int i=0;i<n;i++){
                def = Int64.Parse(lineSplitter[i]);
                valueSortedSet=setSorted.Count;
                setSorted.Add(def);
                if(valueSortedSet!=setSorted.Count){
                    answer[jemeter]=def;
                    jemeter++;
                }
            }
            daviddobrik(lefthalf,answer,righthalf,jemeter,__jmaxVal,finalVal);
	    }
	}   
}