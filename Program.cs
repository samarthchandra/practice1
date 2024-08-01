using System;
using System.Collections.Generic;

namespace Restaurant_Management_System
{

    class Program
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant();

            restaurant.AddMenuItem(new FoodItem("Burger", 39));
            restaurant.AddMenuItem(new FoodItem("Fries", 49));
            restaurant.AddMenuItem(new FoodItem("Samosa", 19));
            restaurant.AddMenuItem(new FoodItem("Momos", 59));
            restaurant.AddMenuItem(new FoodItem("Pizza", 249));
            restaurant.AddMenuItem(new DrinkItem("Tea", 19));
            restaurant.AddMenuItem(new DrinkItem("Coffee", 119));
            restaurant.AddMenuItem(new DrinkItem("water", 29));
            restaurant.AddMenuItem(new DrinkItem("Cold coffee", 149));
            restaurant.AddMenuItem(new DrinkItem("Mint Mojito", 199));

            restaurant.DisplayMenu();

            Console.WriteLine("Enter the items to order:");
            string orderItemsStr = Console.ReadLine();
            string[] orderItemsArr = orderItemsStr.Split(',');
            List<MenuItem>
                orderItems = new List<MenuItem>
                    ();

            foreach (string item in orderItemsArr)
            {
                foreach (var menuItem in restaurant.menuItems)
                {
                    if (menuItem.Name.ToLower() == item.Trim().ToLower())
                    {
                        orderItems.Add(menuItem);
                        break;
                    }
                }
            }

            Console.WriteLine("Press 'y' if you would like to remove items, press any other key to continue:");
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine();

            List<MenuItem>
                orderItemsBeforeRemove = new List<MenuItem>
                    (orderItems);

            if (cki.KeyChar.ToString().ToLower() == "y")
            {
                Console.WriteLine("Enter the items to remove:");
                string removeItemsStr = Console.ReadLine();
                string[] removeItemsArr = removeItemsStr.Split(',');
                List<string>
                    removeItems = new List<string>();

                foreach (string item in removeItemsArr)
                {
                    removeItems.Add(item.Trim());
                }

                foreach (var removeItem in removeItems)
                {
                    foreach (var orderItem in orderItems)
                    {
                        if (orderItem.Name.ToLower() == removeItem.ToLower())
                        {
                            orderItems.Remove(orderItem);
                            break;
                        }
                    }
                }
            }

            double totalCost = restaurant.CalculateTotalOrderCost(orderItems);
            Console.WriteLine("Your Order:");
            foreach (var item in orderItems)
            {
                item.Display();
            }
            Console.WriteLine("Total Cost of Order in rupees: " + totalCost);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}