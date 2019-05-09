using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Test
{
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
		string line = Console.ReadLine();
		int tc = Convert.ToInt32(line);
		while(tc-->0){
		    line = Console.ReadLine();
		    string[] lineSplitter = line.Split(' ');
		    int n = Int32.Parse(lineSplitter[0]);
            int k = Int32.Parse(lineSplitter[1]);
            
            line = Console.ReadLine();
            lineSplitter = line.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++) 
                a[i] = Int32.Parse(lineSplitter[i]);
                
            int answer = 0;
            for (int begin = 0; begin < n; begin++){
                List<int> subArray = new List<int>(n);
                int[] recurrances = new int[2001];
                for (int end = begin; end < n; end++){
                    insertionElement(subArray, a[end]);
                    recurrances[a[end]]++;
                    
                    int l = end - begin + 1;
                    int m = (int) Math.Ceiling((double)k / (double)l);
                    int xi = (k - 1) / m;
                    int x = subArray.ElementAt(xi);
                    int f = recurrances[x];
                    if (f < 2001 && recurrances[f] > 0) {
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);
		}
	}
}
