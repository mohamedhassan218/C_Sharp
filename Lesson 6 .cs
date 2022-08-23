using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Conditional statements:
        string myString = "hello world";
        int myInteger = 9;
        //{ if, if ... else, if .. else if ..... }
        if(myString == "HELLO WORLD!")
            Console.WriteLine("UPPER CASE");
        else if(myString.Length == 1)
            Console.WriteLine("It's not a string, this is a char");
        else
            Console.WriteLine(myString);
        
        //{ switches }
        switch (myInteger)
        {
            case(5):
                Console.WriteLine("The number is " + 5);
                break;
            case(0):
                Console.WriteLine("zero");
                break;
            
            default:
                Console.WriteLine("This is the default case");//is exevuted
            break;
        //Note:
        //U must write an constant value in each case of the switch.
        //Or it will give U a compilation error.
        }
       
        //{ Ternary opearator }
       string isEven = (myInteger % 2 == 1) ? "No" : "Yes";
        Console.WriteLine(isEven);     
        
         
    }
}