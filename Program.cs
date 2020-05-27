using System;
using System.Net.Http.Headers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ShipIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInventory Management\r");
            Console.WriteLine("--------------------");

            Bicycles bicycles = new Bicycles();
            LawnMowers lawnMowers = new LawnMowers();
            BaseballGloves baseballGloves = new BaseballGloves();
            Crackers crackers = new Crackers();

            Shipper shipper = new Shipper();

            int action = ChooseAction();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        shipper.ShoppingList.Add(bicycles);
                        Console.WriteLine("1 Bicycle has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        shipper.ShoppingList.Add(lawnMowers);
                        Console.WriteLine("1 Lawn Mower has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        shipper.ShoppingList.Add(baseballGloves);
                        Console.WriteLine("1 Baseball Glove has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        shipper.ShoppingList.Add(crackers);
                        Console.WriteLine("1 Crackers have been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Shipment manifest:");
                        printInventory(shipper);
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Total shipping costs for this order are $" + shipper.Checkout());
                        Console.WriteLine("Press any key to terminate the program");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                }
                action = ChooseAction();
            }
        }

        static public int ChooseAction()
        {
            int choice = 0;
            Console.WriteLine("\nChoose from the following options:");
            Console.WriteLine("1 - Add a Bicycle to the shipment");
            Console.WriteLine("2 - Add a Lawn Mower to the Shipment");
            Console.WriteLine("3 - Add a Baseball Glove to the shipment");
            Console.WriteLine("4 - Add Crackers to the shipment");
            Console.WriteLine("5 - List Shipment Items");
            Console.WriteLine("6 - Compute Shipping Charges");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        private static void printInventory(Shipper shipper)
        {
            for (int i = 0; i < shipper.ShoppingList.Count; i++)
            {
                Console.WriteLine(i + " " + shipper.ShoppingList[i]);
            }
        }

        //private static void printInventory(Shipper shipper)
        //{
        //    shipper.ShoppingList.Where(s => s != null && s.StartsWith("S")).Count();
        //}

        //private static void printInventory(Shipper shipper)
        //{
        //int count = 0;
        //    foreach (string s in shipper.ShoppingList) 
        //    {
        //        if (s!=null && s.StartsWith("S")) count++;
        //    }
        //}  
    }
}