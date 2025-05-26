using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Doctor 
    {
        public virtual void Consult()
        {
            Console.WriteLine("Consulation Started: ");
        }
    }
    class Cardiologist:Doctor //B is a child class
    {
        public override void Consult()
        {
            Console.WriteLine("ECG and Scan..... ");
        }
    }
    class Dermatologist : Doctor// C is child class
    {
        public override void Consult()
        {
            Console.WriteLine("SKIN RAShes and prevention with cream--- ");
        }
    }
    class Psychiatrist : Doctor
    {
        public override void Consult()
        {
            Console.WriteLine("Mental Illness... ");
        }
    }
    internal class Polymor
    {
       static void Main(String[] arg)
        {
            Console.WriteLine("Choose Doctor: ");
            Console.WriteLine("1.Cardiologist ");
            Console.WriteLine("2.Dermatologist");
            Console.WriteLine("3.Psychiatrist");
            Console.WriteLine("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            Doctor doctor;
            switch(choice)
            {
                case 1: doctor = new Cardiologist();
                        break;
                case 2: doctor= new Dermatologist();
                        break;
                case 3: doctor=new Psychiatrist();
                    break;
                default: Console.WriteLine("Invalid choice: ");
                    return;
            }
            doctor.Consult();//polymorphism

        }
    }
}
