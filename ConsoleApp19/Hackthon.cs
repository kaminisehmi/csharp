/*using System;
using System.Collections.Generic;


namespace ConsoleApp19
{
    //base class
    class Person
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public void Displayperson()
        {
            Console.WriteLine($"Name: {Name},Age: {Age}");
        }
    }
    class Participant:Person
    {
        public string Skill {  get; set; }
        public void Showskill()
        {
            Console.WriteLine($"Skill is: {Skill}");
        }
    }
    class Teamleader:Participant
    {
        public List<string> Teammates=new List<string>();
        public void Addmembers(string m)
        {
            Teammates.Add(m);
        }
        public void ShowTeam()
        {
            Console.WriteLine($"{Name}'s Team members: ");
            foreach (var i in Teammates)
            {
                Console.WriteLine($"- {i}");
            }
        }
    }
    internal class Hackthon
    {
        static void Main(string[] args)
        {
            Teamleader obj1= new Teamleader();
            obj1.Name = "Alice";
            obj1.Age = 34;
            obj1.Skill = "AI/ML Engineer";
            //add data into the list
            obj1.Addmembers("BOB");
            obj1.Addmembers("Charlie");

            Console.WriteLine("=====HACKATHON TEAM MEMBERS====");
            obj1.Displayperson();
            obj1.Showskill();
            obj1.ShowTeam();

            
        }
    }
}
*/