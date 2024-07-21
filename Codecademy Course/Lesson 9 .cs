using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //expression-bodied definitions and lambda expressions:
        Console.WriteLine(IsEven(8));//Prints: True

        Welcome("Mohamed");//Prints: Welcome Mohamed


        //methods as arguments:
        
        int[] numbers = {1, 2, 3, 4, 5};
        //to check every item in the array
        //Array.Exists:
        //if any item is true, the Array.Exists returns true
        Console.WriteLine(Array.Exists(numbers, IsEven)+"\n");//pritns: True
        
        //Array.Find()
        //takes an array and a method as argument, calls the
        //gitven method on each element in the array, and 
        //return the first element for which the method returns true.
        string[] names = {"Ali", "Omar", "Mohamed", "Mustafa", "Sayed"};
        Console.WriteLine(Array.Find(names, IsLong));//Prints: Mohamed
        //Note:
        //in Array.Exists() and Array.Find()
        //the method passed as argument must return a bool value
        
        
        //lambda expression:
        //with one expression:
                    //(input-parameters) => expression
        //with many expressions:
                    //(input-parameters) +> {statement; }
        string[] players = {"Zizo", "Mahmoud Alaa", "Awad", "Mohamed Abdelghany", "Mo salah"};
        //without lambda:
        Console.WriteLine(Array.Find(players, HitGround));//Prints: Mo salah
        //with lambda:
        Console.WriteLine(Array.Find(players, (string word) => word == "Mo salah"));//prints: Mo salah


        //more shortcuts with the lambda expressions:
        
        
        //the normal lambda expression:
        bool hasEvenNumber1 = Array.Exists(numbers, (int number) => number % 2 == 0);
        
        //here we removed the data type:
        bool hasEvenNumber2 = Array.Exists(numbers, (num) => num % 2 == 0);
        
        //here we removed the data type and the parentheses:
        bool hasEvenNumber3 = Array.Exists(numbers, num => num % 2 == 0);
        
        Console.WriteLine(hasEvenNumber1);//Prints: true 
        Console.WriteLine(hasEvenNumber2);//Prints: true 
        Console.WriteLine(hasEvenNumber3);//Prints: true 
        
        //////////////////////////////////////////////////////////////////////////////
        //Review:
        //Expression-bodied definition can be used for one-line methhod bodies.
        //Lambda expressions can be used to create an anonymous method.
        


        
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


    public static bool IsEven(int number)
    {
        return (number % 2 == 0);
    }
    
    public static bool IsLong(string s)
    {
        return s.Length > 4;
    }
    
    public static bool HitGround(string word)
    {
        return word == "Mo salah";
    }
    
    
}