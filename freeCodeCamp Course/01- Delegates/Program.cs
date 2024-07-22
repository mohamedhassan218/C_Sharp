using System;
using System.IO;
using CoverianceAndContraveriance;

namespace DelegateExample
{
    class Program
    {
        delegate void LogDel(string name);

        // Covariant delegate.
        public delegate Animal AnimalReturnDelegate();

        // Contravariant delegate.
        public delegate void AnimalParameterDelegate(Dog dog);

        static void Main(string[] args)
        {
            // 1- DELEGATES
            // Log log = new Log();
            // LogDel logDel1 = new LogDel(LogTextToScreen);
            // LogDel logDel2 = new LogDel(log.LogTextToScreen);
            // LogDel MulticastDel = logDel1 + logDel2;

            // // LogDel logDel = new LogDel(log.LogTextToScreen); // Also works with instance methods.

            // Console.Write("Enter your name:");
            // string name = Console.ReadLine();

            // // MulticastDel.Invoke(name);
            // LogText(name, MulticastDel);


            // 2- COVARIANCE & CONTRAVARIANCE
            // Covariance example.
            // AnimalReturnDelegate animalReturnDelegate = GetDog;
            // Animal animal = animalReturnDelegate();
            // Console.WriteLine($"Animal Name: {animal.Name}");

            // Contravariance example.
            // AnimalParameterDelegate animalParameterDelegate = TakeAnimal;
            // Dog myDog = new Dog { Name = "Buddy" };
            // animalParameterDelegate(myDog);


            // 3- FUNC, ACTION & PREDICATE
            // Func<T>
            Func<Dog> getDog = GetDog;
            Func<Animal> getAnimal = getDog;
            Animal animal = getAnimal();
            Console.WriteLine($"Animal Name: {animal.Name}");

            // Action<T>
            Action<Animal> actionAnimal = PrintAnimal;
            Action<Dog> actionDog = actionAnimal;
            Dog myDog = new Dog { Name = "Buddy" };
            actionDog(myDog);

            // Predicate<T> 
            Predicate<Animal> isAnimalNamedRex = IsNamedRex;
            Predicate<Dog> isDogNamedRex = isAnimalNamedRex;
            bool result = isDogNamedRex(myDog);
            Console.WriteLine($"Is Dog Named Rex: {result}");

            Console.ReadKey();
        }

        // Static method to log text to the screen.
        static void LogTextToScreen(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        // Static method to log text to a file.
        static void LogTextToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        // Delegate as parameter to a method.
        static void LogText(string name, LogDel logDel)
        {
            logDel.Invoke(name);
        }

        // Return a new dog.
        static Dog GetDog()
        {
            return new Dog { Name = "Rex" };
        }

        // Print the name of the animal.
        static void TakeAnimal(Animal animal)
        {
            Console.WriteLine($"Animal Name: {animal.Name}");
        }

        static void PrintAnimal(Animal animal)
        {
            Console.WriteLine($"Animal Name: {animal.Name}");
        }

        static bool IsNamedRex(Animal animal)
        {
            return animal.Name == "Rex";
        }
    }
}
