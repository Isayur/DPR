using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Milk : Decorator
    {
        public Milk(ICoffee newCoffee)
        {
            tempCoffee = newCoffee;
        }

        public override string getDescription()
        {
            return tempCoffee.getDescription() + "Milk, ";
        }
        public override double getCost()
        {
            return tempCoffee.getCost() + .40;
        }
    }
}
