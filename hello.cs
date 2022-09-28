using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("{0}",retstr());

    }
    static public string retstr(){
       
        return "   \x1bc\x1b[42;30m\n hello world\n";
    }

}
