using System;

public class Test
{
    public static void Main(){
        long uno = Int64.MinValue;
        long dos = Int64.MinValue;
        string line = Console.ReadLine();
        long tc = Int64.Parse(line);
        long[] arr = new long[tc];
	    line = Console.ReadLine();
	    string[] lineSplitter = line.Split(' ');
        lineSplitter = line.Split(' ');
	    for(long i=0;i<tc;i++){
            arr[i] = Int64.Parse(lineSplitter[i]);
        }
        
        foreach(long numero in arr){
            if(numero > uno){
            dos = uno;
            uno = numero;
            }    
            else if(numero>dos && numero<uno){
                dos = numero;
            }
        }
        if(dos == Int64.MinValue){
            Console.WriteLine(0);
        }
        else
            Console.WriteLine(dos);
    }
}
