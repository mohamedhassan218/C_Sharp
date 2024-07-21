using System;

namespace OutParameters
{

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
        
            //more dealing with the outcomes of methods:
       
            Console.WriteLine(DecoratePlanet("Jupiter"));
            //Prints: "*.*.* Welcome to Jupiter *.*.*"
       
            //out keyword is used as a parameter modifier, which lets
            //U pass the variable to the method by reference not by value.
            //So any change happens to the parameter is made to the argument.
            //as the keyword ref expect that ref required that the variable
            //be initialized before its passed.
            //Here is some examples:
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;
            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);
            //////////////////////////////////////////
            int nameAsInt;
            bool outcome2;
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);
      
            int myTestVar;//Declare it without initial value.
            myMethodToTestOut(out myTestVar);
            Console.WriteLine(myTestVar);//Prints: 666
       
            myMethodToTest(myTestVar);
            Console.WriteLine(myTestVar);//Prints: 666
            //the value not change because we passed it with value not with reference.
       
        }
    
        static string DecoratePlanet(string planetName)
        {
            string result;
            result = $"\"*.*.* Welcome to {planetName} *.*.*\"";
            return result;
        }
    
    
        //Method can only return one value
        //If U wanna to return more than one information, call
        //method that uses an out parameter.
    
        static void myMethodToTestOut(out int a)
        {
            //This should change the value in the argument a
            a = 666;
        }
    
        //same function without out.
        static void myMethodToTest(int a)
        {
            a = 555;
        }
    }
}