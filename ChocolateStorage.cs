using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    public class milkChocolate : productModel
    {
        public milkChocolate() : base("Milk chocolate", 22, "eat")
        {
        }
    }
    public class darkChocolate : productModel
    {
        public darkChocolate() : base("Dark chocolate", 24, "eat")
        {
        }
    }
}
