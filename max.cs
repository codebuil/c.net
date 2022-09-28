using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine (" \x1bc\x1b[42;30m\n {0}",maxs(20,40));

    }
    static public int maxs(int i1,int i2){
       int a=i1;
       if (a<i2)a=i2;
        return a;
    }

}
