using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        //To print the string inside quotation marks.
        string withSlash = "Ifemelu said, \"Hello!\"";
        Console.WriteLine(withSlash);     
        
        //To print new line.
        string newLine = "Ifemelu walked \n to the park.";
        Console.WriteLine(newLine);
        
        //String concatination:
        int n = 800;
        string s = "Hello World";
        Console.WriteLine(s + n);  //prints: Hello World800.
        //Note: If we want to concatenate a string with something
        //that is another data type, C# will implicitly convert
        //that  value to a string.
        
        //String interpolation(formating):
        string name = "Mohamed";
        Console.WriteLine($"My name is {name}"); //prints: My name is Mohamed
        // Make sure there isn’t a space in between 
        //the $ and the starting quotation mark ". 
        
        //another example:
        string beginning = "Once upon a time,";
        string middle = "The kid climbed a tree";
        string end = "Everyone lived happily ever after.";
        string story = $"{beginning}{middle}{end}"; 
        Console.WriteLine(story);


        //Properities of string variables:
       //{ Length, IndexOf(), Substring(), ToUpper(), ToLower() }
       string name = Console.ReadLine();
       int len = name.Length;
       Console.WriteLine(len);
       
       int indxOfM = name.IndexOf("M");
       Console.WriteLine($"And the index of the char M is { indxOfM }");
       
       string e = "I'm learning C# on online compiler";
       int tempINDX = e.IndexOf("online");//returns the index of the 'o'
       Console.WriteLine(tempINDX);   //Prints: 19
       string mySubString = e.Substring(19);
       Console.WriteLine(mySubString); //Prints: online compiler
       //It takes from the 19 index to the end of the string.
       int lengthOfSubString = 6;
       mySubString = e.Substring(19, lengthOfSubString);
       Console.WriteLine(mySubString);  //Prints: online
       //Here, it takes from the beginning index (19) 
       //a substring of length of 6 chars.
       
       string shouting = "I'm not shouting, U are shouting!".ToUpper();
       Console.WriteLine(shouting); //Prints: I'M NOT SHOUTING, U ARE SHOUTING!
       shouting = shouting.ToLower();
       Console.WriteLine(shouting); //Prints:i'm not shouting, u are shouting!
       
        
        
    }
}