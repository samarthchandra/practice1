using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine(Name + "  Price: " + Price);

        }
    }
}
