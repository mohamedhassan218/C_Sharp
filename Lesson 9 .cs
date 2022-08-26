using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //expression-bodied definitions and lambda expressions:
        Console.WriteLine(IsEven(8));//Prints: True

        Welcome("Mohamed");//Prints: Welcome Mohamed
        
    }
    
    /*bool IsEven(int x)
    {
        return x % 2 == 0;
    }*/
    //the definition above can be replaced with this one:
    static bool IsEven(int x) => x % 2 == 0;
    // '=>' called fat arrow
    
    
    //another example here:
    /*static void Welcome(string name)
    {
        Console.WriteLine($"Welcome {name}");
    }*/
    //the code above can be replaced with this expression:
    static void Welcome(string name) => Console.WriteLine($"Welcome {name}");

    //This type of definition can only be used when a method contains one expression.

    
    
}