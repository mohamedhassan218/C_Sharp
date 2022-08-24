using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Dealing with methods:
        string msg = "Yabba dabba doo!";
        Console.WriteLine(msg);  //Prints: Yabba dabba doo!
        Console.WriteLine(msg.Substring(0,1));  //Pirnts: Y
        
        int smallerNumber = Math.Min(3,4);
        Console.WriteLine(smallerNumber); //Prints: 3
        //U can replace the code above with this line:
        Console.WriteLine(Math.Min(3,4)); //Prints: 3
        
        //Call your own method:
        methodName();
        
        
    }
    
    //Create your own method:
    static void methodName()
    {
        Console.WriteLine("Hi, I'm your method!");
    }
}