using System;

public class HelloWorld
{
    
    class starts{
        
        public starts(int i){
            Console.WriteLine("\x1bc\x1b[42;37m starts {0}]",i);
            
        }
       ~ starts(){
            Console.WriteLine("end");
        }
    }
    static public void Main ()
    
    {
       starts s=new starts(100);

    }
  
}
