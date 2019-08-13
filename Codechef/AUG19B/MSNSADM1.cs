using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
	/*string line = Console.ReadLine();
		line = Console.ReadLine();
	    string[] lineSplitter = line.Split(' ');
        lineSplitter = line.Split(' ');
	    for(int i=0;i<tc;i++){
            arr[i] = Int64.Parse(lineSplitter[i]);
        }*/
public class Test
{
	public static void Main()
	{
	    int tc = Convert.ToInt32(Console.ReadLine());
	    while(tc-->0){
	        int n,i,j=0,resultScore=0;
	        List<int> list_of_Scores = new List<int>();
	        n = Convert.ToInt32(Console.ReadLine());
	        int[] arr1 = new int[n];
	        int[] arr2 = new int[n];
	        
	        string line = Console.ReadLine();
	        string[] lineSplitter = line.Split(' ');
	        lineSplitter = line.Split(' ');
	        for(i=0;i<n;i++){
                arr1[i] = Int32.Parse(lineSplitter[i]);
            }
            line = Console.ReadLine();
	        lineSplitter = line.Split(' ');
	        for(i=0;i<n;i++){
                arr2[i] = Int32.Parse(lineSplitter[i]);
            }
            while(j<n){
				resultScore=(arr1[j]*20)-(arr2[j]*10);
				if(resultScore<0)	
				    resultScore=0;
				    list_of_Scores.Add(resultScore);
				j++;
			}
			var max = list_of_Scores.Max();
            Console.WriteLine(max);
            
	    }
	}   
}










