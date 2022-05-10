using System;
using Vending_machine;
using InputCollectionAndValidation;

namespace Vending_machine
{
    class Program
    {
        private static void Main(string[] args)
        {
            //  Setup
            //User
            userModel user1 = new userModel();
            user1.moneyPool = 0;
            inAndOut validator = new inAndOut();
            programBehaviour execute = new programBehaviour();

            //variables
            bool run = true;

            //run loop
            while (run)
            {
                Console.WriteLine($"You currently have { user1.moneyPool }kr.\n\nWhich of the following would you like to do?\n1. Purchace an item from the vending machine\n2. Look at the items in the vending machine\n3. Insert money\n4. Leave the machine\n\n(Enter the number corresponding with the task you wish to perform))");
                int task = validator.isInt(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        user1.moneyPool = execute.purchase(user1.moneyPool);
                        break;
                    case 2:
                        execute.showAll();
                        break;
                    case 3:
                        user1.moneyPool += execute.insertMoney();
                        break;
                    case 4:
                        execute.endTransaction(user1.moneyPool);
                        run = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
