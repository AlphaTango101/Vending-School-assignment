using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    public class Pringles : productModel
    {
        public Pringles() : base("Pringles", 28, "eat")
        {
        }
    }
    public class Lays : productModel
    {
        public Lays() : base("Lays", 30, "eat")
        {
        }
    }
}
