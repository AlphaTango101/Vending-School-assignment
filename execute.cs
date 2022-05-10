using System;
using System.Collections.Generic;
using InputCollectionAndValidation;

namespace Vending_machine
{
    public class programBehaviour : IVending
    {
        public int purchase(int balance)
        {
            //initalising the products in this method
            List<productModel> products = new List<productModel>();
            products.Add(new cola());
            products.Add(new iceTea());
            products.Add(new Pringles());
            products.Add(new Lays());
            products.Add(new milkChocolate());
            products.Add(new darkChocolate());

            bool another = true;

            while (another)
            {
                Console.Write($"You see {products.Count} items: ");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.Write($"{products[i].name}, ");
                }
                Console.WriteLine("\nWhich one do you wish to purchace.\nOr type \"exit\" to go back to the main menu.");
                string holder = Console.ReadLine();
                while (!(holder != "exit" || holder == products[0].name || holder == products[1].name || holder == products[2].name || holder == products[3].name || holder == products[4].name || holder == products[5].name))
                {
                    Console.WriteLine("Your input was invalid, please try again.");
                    holder = Console.ReadLine();
                }
                Console.WriteLine($"You purchace a {holder}, would you like to use this item? (yes/no)");
                string useHolder = Console.ReadLine().ToLower();
                while (!(useHolder == "yes" || useHolder == "no"))
                {
                    Console.WriteLine("Your input was invalid, please try again.");
                    useHolder = Console.ReadLine().ToLower();
                }
                for (int i = 0; i < products.Count; i++)
                {
                    if (holder == products[i].name)
                    {
                        if (balance < products[i].price)
                        {
                            Console.WriteLine($"You cannot afford the {products[i].name}.");
                        }
                        else
                        {
                            balance -= products[i].price;
                            if (useHolder == "yes")
                            {
                                products[i].use();
                            }
                        }
                    }
                }
                Console.WriteLine("Would you like to purcase another item? (yes/no)");
                useHolder = Console.ReadLine().ToLower();
                while (!(useHolder == "yes" || useHolder == "no"))
                {
                    Console.WriteLine("Your input was invalid, please try again.");
                    useHolder = Console.ReadLine().ToLower();
                }
                if (useHolder == "no")
                {
                    another = false;
                }
            }
            Console.Read();
            return balance;
        }
        public void showAll()
        {
            //initalising the products in this method
            List<productModel> products = new List<productModel>();
            products.Add(new cola());
            products.Add(new iceTea());
            products.Add(new Pringles());
            products.Add(new Lays());
            products.Add(new milkChocolate());
            products.Add(new darkChocolate());

            Console.WriteLine($"You see {products.Count} products;");
            for (int i = 0; i < products.Count; i++)
            {
                products[i].examine();
            }

            Console.Read();
        }
        public int insertMoney()
        {
            inAndOut validator = new inAndOut();
            string holder;
            int[] denominations = new int[8] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            bool toInsert = true;
            int inserted = 0;
            while (toInsert)
            {
                int insertHolder = 0;
                Console.WriteLine("What size note would you like to insert? (1000, 500, 100, 50, 20, 10, 5, 1)\nOr type \"exit\" to go back to the main menu.");
                holder = Console.ReadLine().ToLower();
                if (holder != "exit")
                {
                    insertHolder = validator.isInt(holder);
                }
                else
                {
                    toInsert = false;
                }
                foreach (int note in denominations)
                {
                    if (insertHolder == note)
                    {
                        Console.WriteLine("Your note has be inserted successfully.");
                        inserted += insertHolder;
                    }
                }
            }
            return inserted;
        }
        public void endTransaction(int remainder)
        {
            int[] denominations = new int[8] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] returnedNotes = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < denominations.Length; i++)
            {
                while (remainder >= denominations[i])
                {
                    remainder -= denominations[i];
                    returnedNotes[i]++;
                }
            }
            for (int i = 0; i < returnedNotes.Length; i++)
            {
                if (returnedNotes[i] > 0)
                {
                    Console.WriteLine($"You recieve { returnedNotes[i] } { denominations[i] }kr notes,");
                }
            }
            Console.Read();
        }
    }
}
