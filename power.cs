using System;

public class HelloWorld
{
    static public void Main ()
    {
        int n=0;
        for(n=0;n<16;n++){
        Console.WriteLine (" \x1bc\x1b[42;30m\n {0}",power(2,n));
        }

    }
    static public int power(int i1,int i2){
       int a=i1;
       int n=0;
       if(i2==0)return 1;
       if(i2==1) return i1;
       for(n=1;n<i2;n++)a=a*i1;
        return a;
    }

}
