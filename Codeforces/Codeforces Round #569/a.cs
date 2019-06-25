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
	    int a=1,result=0;
	    int n = Convert.ToInt32(Console.ReadLine());
	    for(int i=1;i<=n;i++){
		    result += a;
		    a += 2;
	    }
	    a=1;
		for(int i=1;i<=n-1;i++){
		    result+=a;
		    a+=2;
		}
		if(n==1)
		    result=1;
		Console.WriteLine(result);
	}   
}