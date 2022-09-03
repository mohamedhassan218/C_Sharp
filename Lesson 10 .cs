using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //introduction to arrays:
        
        int[] intArray = {1, 2, 3, 4, 5};//declare and initiate
        double[] doubleArray = new double[] {1000.0, 2.0, 30.0, -44.5};//declare and initiate with the new keyword
        
        string[] stringArray;
        //if U wanna to declare in line and initiate in another line, 
        //U must use the new keyword
        stringArray = new string[] {"Mohamed", "Hassan", "Fathy"};
        
        //array length:
        Console.WriteLine(intArray.Length);//Prints: 5
        
        //access array items:
        //array in C# zero indixed:
        Console.WriteLine(stringArray[0]);//Prints: Mohamed
        Console.WriteLine(stringArray[1]);//Prints: Hassan
        Console.WriteLine($"The first number in the intArray is {intArray[0]}");
        //Prints: The first number in the intArray is 1
        
        //editing array:
        stringArray[0] = "ZIZO";
        Console.WriteLine(stringArray[0]);//Prints: ZIZO 
        
        //use the bulit-in methods:
        //SORT ===> sort the given array
        Console.WriteLine(doubleArray[0]);//Prints: 1000
        Array.Sort(doubleArray);
        Console.WriteLine(doubleArray[0]);//Prints: -44.5
        
        //INDEX OF ===> return the index of the given item
        Console.WriteLine(Array.IndexOf(stringArray, "ZIZO")); //Prints: 0
        //if the given item not in the array, prints -1
        Console.WriteLine(Array.IndexOf(stringArray, "MO SALAH"));//Prints: -1
        
        //FIND ===> searchs the array for a specific value or set of values
        //that match a condition and return the first occurrence in the array.
        int firstOddNumber = Array.Find(intArray, number => number % 2 == 1);
        Console.WriteLine(firstOddNumber);//Prints: 1
        string longName = Array.Find(stringArray, name => name.Length > 5);
        Console.WriteLine(longName);//Prints: Hassan
        //the first name that has more than 5 characters.
        
        
        //COPY ===> copy an array to another:
        string[] copiedStringArray = new string[3];
        Array.Copy(stringArray, copiedStringArray, 3);
        Console.WriteLine(copiedStringArray[0] + " " + copiedStringArray[1] + " "+ copiedStringArray[2] );
        //Prints: ZIZO Hassan Fathy
        // 3 is the length of the items to be copied
        
        
        //REVERSE ===> reverse the order of the array
        Array.Reverse(doubleArray, 0, 4);
        Console.WriteLine(doubleArray[0]);//Prints: 1000
        //reverse the subset between the 0 and 4 including 3
        

        //CLEAR ===> sets the range of elements to the default value.
        Array.Clear(intArray, 0, 5);
        Console.WriteLine(intArray.Length);//Prints: 5
        Console.WriteLine(intArray[0]);//Prints: 0

        
    }
}