using System;

	/*string line = Console.ReadLine();
		line = Console.ReadLine();
	    string[] lineSplitter = line.Split(' ');
        lineSplitter = line.Split(' ');
	    for(long i=0;i<tc;i++){
            arr[i] = Int64.Parse(lineSplitter[i]);
        }*/
public class Test
{
	public static void Main()
	{
	    long tc = Convert.ToInt64(Console.ReadLine());
	    while(tc-->0){
	        long n,k;
	        string line = Console.ReadLine();
	        string[] lineSplitter = line.Split(' ');
	        lineSplitter = line.Split(' ');
	        n = long.Parse(lineSplitter[0]);k = long.Parse(lineSplitter[1]);
	        n=n/k;
	        if(n%k==0)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES\n");
        }
	}
}   
