using System;
using System.Linq;

public class Test
{
	public static void Main()
	{
		int t = Convert.ToInt32(Console.ReadLine());
		while(t > 0){
			t--;
			int r,c;
			string [] arr1 = (Console.ReadLine()).Split();
			r = Convert.ToInt32(arr1[0]);
			c = Convert.ToInt32(arr1[1]);
			int [,] arr = new int[r,c];
			for(int i=0; i<r; i++){
				for (int j=0; j<c; j++){
					int max =4;
					if(i==0 || i==r-1)
						max--;
					if(j==0 || j==c-1)
						max--;	
					arr[i,j] = max;
				}
			}
			bool flag = true;
			for(int i=0; i<r; i++){
				var numbers = Console.ReadLine().Split().Select(Int32.Parse).ToList();
				for (int j=0; j<c; j++){
					if(arr[i,j] <= numbers[j]){
						flag = false;
					}
					
				}
			}
			if(flag){
				Console.WriteLine("Stable");
			}
			else{
				Console.WriteLine("Unstable");
			}
		}
	}
}