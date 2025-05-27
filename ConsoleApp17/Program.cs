using System;


namespace ConsoleApp17
{
    class Animal
    {
        public virtual void animalsound()
        {
            Console.WriteLine("The animal makes sound: ");
        }
    }
    class Pig: Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("This is a pig class: ");
        }
    }
    class Dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("This is a Dog class: ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Animal obj1 = new Animal(); //animal object
            Animal obj2=new Pig();   //pig object
            Animal obj3= new Dog(); //dog object
            obj1.animalsound();
            obj2.animalsound();
            obj3.animalsound();

        }
    }
}
