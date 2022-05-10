using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    public class userModel
    {
        public int moneyPool;
    }

    public abstract class productModel
    {
        public string name { get; set; }
        public int price { get; set; }
        public string usageType { get; set; }
        public void use()
        {
            Console.WriteLine($"You { usageType } the { name }.");
        }
        public void examine()
        {
            Console.WriteLine($"The { name } costs { price }.");
        }
        public productModel(string name, int price, string usageType)
        {
            this.name = name;
            this.price = price;
            this.usageType = usageType;
        }
    }

    
    
    
}
