
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        //double is usually the best choice of the three
        //{float, decimal and double}
        //it is more precise than a float and faster to process than decimal.
        
        int c = 29;
        //the 'f' character to tell the compiler that it's a float.
        float f = 78.8f;
        double d = 57577575.98;
        
        //Note the decimal data type:
        decimal K = 987798.9898m;
        
        //Don’t forget the m character after the number! 
        //This character tells C# that we’re defining a decimal and not a double.
        
        Console.WriteLine(K);           //Prints: 987798.9898
    
        Console.WriteLine(5 / 3);       //Prints: 1
        
        Console.WriteLine(5 / 3.0);     //Prints: 1.666666666667
    
        
        
    }
}