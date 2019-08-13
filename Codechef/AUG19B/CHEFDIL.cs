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
        string str;
        int tc = Convert.ToInt32(Console.ReadLine());
        while(tc-->0){
            str = Console.ReadLine();
            int res=0;
            int strLength = str.Length;
            for(int i=0;i<strLength;++i){
    		    if(str[i]=='1') 
    		        res++;
            }
            if(res%2==0) 
    	        Console.WriteLine("LOSE");
    	    else 
                Console.WriteLine("WIN");
        }
	}   
}