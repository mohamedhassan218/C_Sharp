using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
        //instantiate an instance of the class Forest, and set values to its fields.
        Forest f = new Forest();
        f.Name = "moHassan218";     //the set for the Name properity is called here
        f.biome = "Never give up";
        f.Trees = 25;                //the set for the Trees properity is called here
        f.age = 20;
        Console.WriteLine(f.name);   //the get of the Name properity is called here

        





    }
  }
}
