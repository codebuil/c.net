using System;

public class HelloWorld
{
    static public void Main ()
    {
        int n;
        long l=1;
        Console.WriteLine ("\x1bc\x1b[42;30m ]Hello World");
        
           for (n=0;n<64/4;n++){
               Console.WriteLine("d{0}",l);
               Console.WriteLine("h{0:x}",l);
               l=mults(l,16);
           }
    }
    static public long mults(long a,long b){
        return a*b;
    }

}
