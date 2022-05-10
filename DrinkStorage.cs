using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    public class cola : productModel
    {
        public cola() : base("Cola", 12, "drink")
        {
        }
    }
    public class iceTea : productModel
    {
        public iceTea() : base("Ice tea", 16, "drink")
        {
        }
    }
}
