/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Book
    {
        public string title;
        public string author;
        public double price;
        //default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;

        }
        //Parametrised constructor
        public Book(string t,string a,double p)
        {
            title = t;
            author = a;
            price = p;
        }
        public void Display()
        {
            Console.WriteLine($"{title},{author},{price}");
        }
        
    }
    internal class Program2
    {
        static void Main()
        {
            Book book = new Book();//default constructor
            Book book2 = new Book("c#sharp","John Doe",29.99);
            book.Display();
            book2.Display();

        }
    }
}
*/