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


        method1(8);//8
        method1();//0
        
        //to put value to a specific variable and not the all
        //First, sure that U have put default value for each variable
        method2(c : 89);
        //if U enter them mentioning each parameter name, U can put them in any order.
        method2(c : 9, b : 110, a : 123);
        
        //Calling methods with same name but different parameters:
        NamePets("KOKO", "MAEA");
        NamePets("KOKO", "MAEA", "LOLO");
        NamePets();
        
        
    }
    
    //Create your own method:
    static void methodName()
    {
        Console.WriteLine("Hi, I'm your method!");
    }


    //the method must be static to call it without taking a reference from the class.
    //0 here is a default value , if the user call the method without put any number.
    static void method1(int number = 0)
    {
        Console.WriteLine($"The number is {number}");
    }
    
    static void method2(int a = 0, int b = 0, int c = 0)
    {
        Console.WriteLine($"a is {a}\nb is {b}\nc is {c}");
    }
    
    //Lets practice with method overloads:
     static void NamePets(string s1, string s2)
    {
      Console.WriteLine($"Your pets {s1} and {s2} will be joining your voyage across space!");
    }
    
    static void NamePets(string s1, string s2, string s3)
    {
      Console.WriteLine($"Your pets {s1}, {s2}, and {s3} will be joining your voyage across space!");
    }

    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
    
}