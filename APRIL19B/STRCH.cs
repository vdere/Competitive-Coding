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
    
	public static void Main()
	{
	    string s;
	    char c;
	    long n;
		long tc = Convert.ToInt64(Console.ReadLine());
		while(tc-->0){
		    string line = Console.ReadLine();
		    n = Int64.Parse(line);
		    line = Console.ReadLine();
		    string[] lineSplitter = line.Split(' ');
            lineSplitter = line.Split(' ');
            s = lineSplitter[0];
            c = Char.Parse(lineSplitter[1]);
            Console.WriteLine(substr(n,s,c));
            /*
            2
            3
            abb b
            6
            abcabc c
            */
		}
	}
}
