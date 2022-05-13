using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Vending_machine;

namespace Vending.test
{
    public class VendingMachineShould
    {
        [Fact]
        public void testCola()
        {
            cola product = new cola();
            bool passed = false;
            if ("Cola" == product.name && 12 == product.price && "drink" == product.usageType)
            {
                passed = true;
            }
            Assert.True(passed);
        }
        [Fact]
        public void testChips()
        {
            Lays product = new Lays();
            bool passed = false;
            if ("Lays" == product.name && 30 == product.price && "eat" == product.usageType)
            {
                passed = true;
            }
            Assert.True(passed);
        }
        [Fact]
        public void testIceTea()
        {
            iceTea product = new iceTea();
            bool passed = false;
            if ("Ice tea" == product.name && 16 == product.price && "drink" == product.usageType)
            {
                passed = true;
            }
            Assert.True(passed);
        }
    }
}
