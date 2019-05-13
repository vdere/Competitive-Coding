/*
C# Code
*/
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
  
	public static void Main()
	{
	    //var line = Console.ReadLine();
		//line = Console.ReadLine();
	    int tc = Convert.ToInt32(Console.ReadLine());
	    while(tc-->0){
	        //line = Console.ReadLine();
	        int n = Convert.ToInt32(Console.ReadLine());
	        double[] x = new double[n];
	        double[] y = new double[n];
	        double[] array1 = new double[n];
	        double[] array2 = new double[n];
	        
	        for(int i=0;i<n;i++){
	            var line = Console.ReadLine().Split();
	            //string[] lineSplitter = line.Split(' ');
                //lineSplitter = line.Split(' ');
                x[i] = Double.Parse(line[0]);
                y[i] = Double.Parse(line[1]);
                array1[i] = x[i] + y[i];
                array2[i] = x[i] - y[i];
	        }
	        Array.Sort(array1);Array.Sort(array2);
	        double minimumVal = Math.Abs((array1[0]-array1[1])/2);
	        minimumVal = Math.Min(Math.Abs((array2[0]-array2[1])/2),minimumVal);
	        for (int i=1;i<n-1;i++) {
                minimumVal = Math.Min(Math.Abs((array1[i]-array1[i+1])/2),minimumVal);
                minimumVal = Math.Min(Math.Abs((array2[i]-array2[i+1])/2),minimumVal);
                if(minimumVal==0.0)
                {
                    break;
                }
            }
            Console.WriteLine(minimumVal);
	    }
	}   
}