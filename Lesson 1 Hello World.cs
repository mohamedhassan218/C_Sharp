using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine ("Hello Mono World");   //Prints --> Hello Mono World.

         Console.WriteLine ("Enter Your Age:");
        string input = Console.ReadLine();        //Takes input from user.  EX: (20)

        Console.WriteLine($"Your Age is {input}"); //Prints --> Your Age is 20.
        Console.WriteLine("Your Age is {input}");  //Prints --> Your Age is {input}. 
        
        //comment in one line.

        /*Comment 
          in 
          many 
          lines*/


    }
}