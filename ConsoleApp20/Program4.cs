/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class product
    {
        double price; //field
        //use the concept of getter and setters
        public double Price
        {
            get { return price; } //read
            set
            {
                if (value >= 0) //write
                    price = value;
                
            }
        }
            public void DisplayPrice()
        {
            Console.WriteLine($"{price}");
        }
    }
    internal class Program4
    {
        static void Main()
        {
            product product = new product();
            product.Price = 999.99;
            product.DisplayPrice();
        }
    }
}
*/