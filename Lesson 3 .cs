
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
    

        int numberOne = 12932;
        int numberTwo = -2828472;
        double numberOneSqrt = Math.Sqrt(numberOne);
        Console.WriteLine(numberOneSqrt); //Prints: 113.718951806636.
        
        double numberTwoSqrt = Math.Sqrt(numberTwo);
        Console.WriteLine(numberTwoSqrt); //Prints: NaN.
        // NaN stands for “Not a Number” in C#. 
        //This happens because the built-in method Math.Sqrt() can only take a
        //positive number as a value, but the value of numberTwo is negative.

        numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
        Console.WriteLine(numberTwoSqrt); //Prints: 1681.
        

        //U can also use the built-in methods:
        //Math.Pow(), Math.Min(), Math.Max(), Math.Ceiling()
        //Note: the letters are in uppercase.
        
        
        
    }
}