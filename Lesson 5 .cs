using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       //dealing with boolean:
       bool boolVariable = true;
       Console.WriteLine(boolVariable); //Prints: True
       //U can declare bool variable using the comparision opearators:
       //{ <, >, ==, !=, <=, >= } 
       boolVariable = 45 < 0;
       Console.WriteLine(boolVariable); //Prints: False
       
       //U can declare many var in the same line:
       double x = 9.9, y = 78.09, z = 8989.0;
       
       //Using the logical opearators:
       //{ ||, &&, ! }
       boolVariable = ((1 < 5) && (65 > 8));
       Console.WriteLine(boolVariable); //Prints: True
        
       boolVariable = ((1 > 5) || (65 < 8));    
       Console.WriteLine(boolVariable); //Prints: False
       
       boolVariable = !(65 < 8);
       Console.WriteLine(boolVariable); //Prints: True
       
       
    }
}