using System;

namespace BasicClasses
{
    //here we create a new class called Forest, it must be in a file naming with same name
    class Forest
    {
        //in C#, these called the fields of the class.
        private string name;
        private string biome;                                //public fields can be accessed by any class 
        private int trees;                                   //private accessed only by the class members     
        private int age;                                     //so make Ur fields private to implement the principle of encapsulation.
                                                             //private and public can be put to the set and get and to our properities.


    //CONSTRUCTOR:  

    public Forest()
    {
        //empty default constructor
        //non-parameters constructor
    }

    //without using this keyword:
    public Forest(string n, string biome)
    {
        Name = n;
        Biome = biome;
        age = 0;
    }

    //using this:
    //this ===> refer to the current instance of a variable of the class:
    //: this() ===> refer to the first constructor and set these values to it.
    //now if you called this constructor, U won't set a value to the biome 
    //it will set to Unknown thanks to : this() 
    public Forest(string name, int trees, int age) : this(name, "Unknown")
    {
        this.Name = name;
        this.Biome = biome;
        this.trees = trees;
        this.age = age;
    }

    //properities:
    public string Name
    {
      get{return name;}
      set{name = value;}
    }

    public int Trees
    {
      get{return trees;}
      set{trees = value;}
    }

    public string Biome
    {
      get{return biome;}
      set
      {
        if(value == "Tropical" || value == "Temperate" || value == "Boreal")
        {biome = value;}
        else
        {biome = "Unknown";}
      }
    }

    //U can define an automatic properities in this way:
    //now, in the back ground there are a string variable called automaticVar defined and set to null
    //U can now put value to it or get it's value like all properities above
    int automaticVar
    {get; set;}


    //the third part of the class is the methods:
    public int Grow()
    {
        automaticVar++;
        return automaticVar;  //Note: we accessed it with the name of the properity not the name of the variable
    }




    }
}
