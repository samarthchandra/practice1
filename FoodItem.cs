using Restaurant_Management_System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant_Management_System
{
    class FoodItem : MenuItem
    {
        public FoodItem(string name, double price) : base(name, price) { }

        public void Display()
        {
            Console.WriteLine(Name + "  Price: " + Price);
        }
    }
}
