using Restaurant_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    class Restaurant
    {
        public List<MenuItem>
            menuItems;

        public Restaurant()
        {
            menuItems = new List<MenuItem>
                ();
        }

        public void RemoveMenuItem(string itemName)
        {
            foreach (var item in menuItems)
            {
                if (item.Name.ToLower() == itemName.ToLower())
                {
                    menuItems.Remove(item);
                    Console.WriteLine("Item " + itemName + " is removed.");
                    Console.WriteLine("-------------------------------------------------------------");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        public void RemoveMenuItems(List<string>
            itemNames)
        {
            foreach (var itemName in itemNames)
            {
                RemoveMenuItem(itemName);
            }
        }

        public void AddMenuItem(MenuItem item)
        {
            menuItems.Add(item);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("The Menu Items are:");

            Console.WriteLine("-------------------------------------------------------------");
            foreach (var item in menuItems)
            {
                item.Display();
            }
            Console.WriteLine("-------------------------------------------------------------");
        }

        public double CalculateTotalOrderCost(List<MenuItem>
            orderItems)
        {
            double totalCost = 0;
            foreach (var item in orderItems)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }
    }
}
