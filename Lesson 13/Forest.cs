//the importance of the static variable is to make a variable 
//related to the type itself, not the instances.
//like create a static variable to count the number of instances
//to make a field or a properity static, just add the keyword static after the access modifier
//if U try to access a static member from an instace, this will lead to an error.

using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private static int forestsCreated; //static variable to count the number of instances
    private static string treeFacts;


    // CONSTRUCTORS
    //An instance constructor is run before the instance is used, the static
    //constructor is run once before the class is used:
    //Forest f = new Forest();   Forest.PrintTreeFacts();
    //in the two cases above, the static constructor is run
    //typically, we use the static constructor to set values to static fields and properities
    //It doesn't accept an access modifier.

    //static constructor:
    static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
    }


    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    // PROPERTIES
     public static int ForestsCreated       //static properity to set and get the value of the forestsCreated static variable.
     {
         get{return forestsCreated;}
         private set {forestsCreated = value;}
     }

    public static string TreeFacts
    {
      get{return treeFacts;}
    }

    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    // METHODS
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }

    //static methods can only access static members, not the instance members:
    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }
    
  }

}
//static class can't be instantiated, so U only need to do this if U are making a library
//or a utility
//static classes like : Console, Math
//they're static because they're just tools, they don't need specific instances and they don't store new information.

