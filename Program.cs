using System;

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
                        PrintInventory(shipper);
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

        private static void PrintInventory(Shipper shipper)
        {
            if(PrintBicycles(shipper) > 1)
            {
                Console.WriteLine(PrintBicycles(shipper) + " Bicycles");
            }
            else if(PrintBicycles(shipper) > 0)
            {
                Console.WriteLine(PrintBicycles(shipper) + " Bicycle");
            }
            if(PrintMowers(shipper) > 1)
            {
                Console.WriteLine(PrintMowers(shipper) + " Lawn Mowers");
            }
            else if(PrintMowers(shipper) > 0)
            {
                Console.WriteLine(PrintMowers(shipper) + " Lawn Mower");
            }
            if(PrintGloves(shipper) > 1)
            {
                Console.WriteLine(PrintGloves(shipper) + " Baseball Gloves");
            }
            else if(PrintGloves(shipper) > 0)
            {
                Console.WriteLine(PrintGloves(shipper) + " Baseball Glove");
            }
            if(PrintCrackers(shipper) > 0)
            {
                Console.WriteLine(PrintCrackers(shipper) + " Crackers");
            }
        }

        private static int PrintBicycles(Shipper shipper)
        {
            int count = 0;
            foreach (var s in shipper.ShoppingList)
            {
                if (s.Product == ("Bicycle")) count++;
            }
            return count;
        }

        private static int PrintMowers(Shipper shipper)
        {
            int count = 0;
            foreach (var s in shipper.ShoppingList)
            {
                if (s.Product == ("Lawn Mower")) count++;
            }
            return count;
        }

        private static int PrintGloves(Shipper shipper)
        {
            int count = 0;
            foreach (var s in shipper.ShoppingList)
            {
                if (s.Product == ("Baseball Glove")) count++;
            }
            return count;
        }

        private static int PrintCrackers(Shipper shipper)
        {
            int count = 0;
            foreach (var s in shipper.ShoppingList)
            {
                if (s.Product == ("Crackers")) count++;
            }
            return count;
        }
    }
}