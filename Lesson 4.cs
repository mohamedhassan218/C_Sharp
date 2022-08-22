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
        
        
    }
}