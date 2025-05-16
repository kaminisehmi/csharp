
/*Design and implement a zoo simulation program using object-oriented programming principles, especially inheritance.
You must:
Create a base class Animal with common properties and methods
Extend this base class into Lion, Elephant, Giraffe, Parrot, etc /Each derived class should override or extend behavior such as MakeSound(), Move(), Feed(), etc.
Allow zookeepers to:
View all animals
Feed specific animals
Get reports on animal behavior
Implement a simple user interface (console-based) to interact with the zoo simulation
*/
using System;
using System.Collections.Generic;
using System.Linq;
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
    public virtual void Move()
    {
        Console.WriteLine($"{Name} moves around.");
    }
    public virtual void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
    }
}
//Extend this base class into Lion, Elephant, Giraffe, Parrot, etc.

public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "Lion") { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars.");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} prowls.");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "Elephant") { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets.");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} lumbers.");
    }
}
public class Giraffe : Animal
{
    public Giraffe(string name, int age) : base(name, age, "Giraffe") { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} bleats.");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} gallops.");
    }
}
public class Parrot : Animal
{
    public Parrot(string name, int age) : base(name, age, "Parrot") { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} squawks.");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} flaps its wings.");
    }
}
//create main class
public class Zoo
{
    //create main method here
    public static void Main(string[] args)
    {
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Lion("Leo", 5));
        zoo.AddAnimal(new Elephant("Ella", 10));
        zoo.AddAnimal(new Giraffe("Gigi", 7));
        zoo.AddAnimal(new Parrot("Polly", 2));
        Console.WriteLine("All Animals in the Zoo:");
        zoo.ViewAnimals();
        Console.WriteLine("\nFeeding Leo:");
        zoo.FeedAnimal("Leo");
        Console.WriteLine("\nGetting report for Ella:");
        zoo.GetAnimalReport("Ella");
        Console.WriteLine("\nGetting report for all animals:");
        zoo.GetAllAnimalReports();
    }
    //create a list of animals
    private List<Animal> animals = new List<Animal>();
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public void ViewAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} is a {animal.Age} year old {animal.Species}.");
        }
    }
    public void FeedAnimal(string name)
    {
        var animal = animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (animal != null)
        {
            animal.Feed();
        }
        else
        {
            Console.WriteLine($"Animal named {name} not found.");
        }
    }
    public void GetAnimalReport(string name)
    {
        var animal = animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (animal != null)
        {
            Console.WriteLine($"{animal.Name} is a {animal.Age} year old {animal.Species}.");
            animal.MakeSound();
            animal.Move();
        }
        else
        {
            Console.WriteLine($"Animal named {name} not found.");
        }
    }
    public void GetAllAnimalReports()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} is a {animal.Age} year old {animal.Species}.");
            animal.MakeSound();
            animal.Move();
        }
    }
}