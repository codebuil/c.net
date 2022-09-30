using System;

public class HelloWorld
{
    
    static public double scale0_10(double a){
        double b=a;
        if (a<0)b=0.00;
        if (a>10.00)b=10.00;
        b=b*10.00;
        return b;
    }
    static public void Main ()
    
    {
        double a ;
        for (a=0.00;a<11.00;a++)Console.WriteLine("\x1b[42;30m {0}]",scale0_10(a));
      

    }
  
}
