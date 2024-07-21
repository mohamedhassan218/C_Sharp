using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //dealing with loops:{while, do-while, for, foreach}
        
        //while(condition)
        //{
        //  statement;  
        //}
        string helloWorld = "Hello World";
        int counter = 3;
        while(counter > 0)
        {
            Console.WriteLine(helloWorld + "\n");
            counter--;
        }
        
        counter = 5;
        //do
        //{
        //  statement;   
        //}while(condition);
        do
        {
            Console.WriteLine(helloWorld + "\n");
            counter--;
        }while(counter > 0);
        
        //for(initialization; stopping condition; iteration statement)
        //{
        //  statement;
        //}
        for(int i = 0; i < 7; i++)
        {
            Console.WriteLine(helloWorld);
        }
        
        //foreach(type element in sequence)
        //{
        //  statement;
        //}
        string[] alphabets = {"a", "b", "c", "d"};
        foreach(string character in alphabets)
        {
            Console.WriteLine(character + "\n");
        }
        
        //jump statements: {break, continue, return}:
        bool playerIsAlive = true;
        int number = 8;
        
        //break:
        while(number > 0)
        {
            Console.WriteLine("HIIIII");
            if(number % 2 == 1)
            {
                playerIsAlive = false;
            }
            if(!playerIsAlive)
            {
                break;
            }
            number--;
        }
        //stops after printing HIIIII twice;
        
        number = 8;
        playerIsAlive = true;
        //continue:
        while(number > 0)
        {
            Console.WriteLine("Mo salah is the Egyptian king");
            if(number % 2 == 1)
            {
                playerIsAlive = false;
            }
             number--;
            if(playerIsAlive == false)
            {
                continue;
                Console.WriteLine(helloWorld);
            }
           
        }//prints Mo salah is the Egyptian king 8 times without printing any Hello world
       
       int[] checkMethod1 = {2, 4, 5}; 
       int[] checkMethod2 = {1, 4, 5};
       Console.WriteLine(PrintsEvenNumbers(checkMethod1));//prints: 2
       Console.WriteLine(PrintsEvenNumbers(checkMethod2));//prints: -1
    }
    
    //return can be used in methods:
    static int PrintsEvenNumbers(int[] arr)
    {
        foreach(int number in arr)
        {
            if(number % 2 == 0)
                return number;
            else
                return -1;
        }
        return -1;
    }
}