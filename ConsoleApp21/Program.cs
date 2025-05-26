using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Basesalary { get; set; }
        public Employee(string name, int id, double sal)
        {
            Name = name;
            ID = id;
            Basesalary = sal;
        }
        public virtual double CalculateSalary()
        {
            return Basesalary;
        }
        public override string ToString()
        {
            return $"ID: {ID} and Name: {Name} Basesalary {Basesalary}";
        }
        class FullTimeEmployee : Employee
        {
            public double Bonus { get; set; }
            public FullTimeEmployee(string name, int id, double sal, double bonus) : base(name, id, sal)
            {
                Bonus = bonus;
            }
            public override double CalculateSalary()
            {
                return Basesalary + Bonus;
            }
            public override string ToString()
            {
                // return $"ID: {ID} and Name: {Name} Basesalary {Basesalary} Bonus: {Bonus}";
                return $"Full time employees details are{base.ToString()},Bonus is :{Bonus},Final salary is: {CalculateSalary()} ";
            }
        }
        class Parttimeemployees : Employee
        {
            public double Hourlyrate { get; set; }
            public int Hoursworked { get; set; }
            public Parttimeemployees(string name, int id, double sal, double hourlyrate, int hourseworked) : base(name, id, 0)
            {
                Hourlyrate = hourlyrate;
                Hoursworked = hourseworked;
            }
            public override double CalculateSalary()
            {
                return Hourlyrate * Hoursworked;
            }
            public override string ToString()
            {
                // return $"ID: {ID} and Name: {Name} Basesalary {Basesalary} Bonus: {Bonus}";
                return $"Full time employees details are{base.ToString()},Hourlyrate {Hourlyrate},Hourswored{Hoursworked} final salary is: {CalculateSalary()} ";
            }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Employee> employees = new List<Employee>
                {
                    new FullTimeEmployee("Alice",101,40000,1000),
                    new Parttimeemployees("Bob",102,50000,25,100)
                };

                foreach (var emp in employees)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}
    

