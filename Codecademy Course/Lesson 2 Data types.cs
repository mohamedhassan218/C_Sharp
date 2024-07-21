using System;
using System.Collections.Generic;

namespace Form
{
public class DataTypes
{
    public static void Main(string[] args)
    {
      string name = "Shadow";
      string breed = "Golden Retriever";
      int age = 5; 
      double weight = 65.22;
      bool spayed = true;
      
      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);

      //The output:
        //Shadow
        //Golden Retriever
        //5
        //65.22
        //True
      

      //The explict casting.
        double myDouble = 3.2;
        int myInt = (int)myDouble;
        Console.WriteLine(myInt);       //prints 3


        //Notes:
        //Console.ReadLine(): takes only strings, not int
        //if we wanna to take int we can explict cast it 
        //Look the code :
        
        //Ask user to input a number
        Console.Write("Enter your favorite number!: ");

        //Console.ReadLine() takes only strings, so U have to convert it to int.
        int faveNumber = Convert.ToInt32(Console.ReadLine()); 


        //convert a boolean to a string.
        bool var = true;
        string castedString = var.ToString();
        Console.WriteLine(castedString);
        
        //convert a string to a list of characters.
        string str = "ABCDE";

		List<char> chars = new List<char>();
		chars.AddRange(str);

		Console.WriteLine(String.Join(", ", chars));


    }
}
}