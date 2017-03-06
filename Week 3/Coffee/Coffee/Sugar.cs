using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Sugar : Decorator
    {
        public Sugar(ICoffee newCoffee)
        {
            tempCoffee = newCoffee;
        }

        public override string getDescription()
        {
            return tempCoffee.getDescription() + "Sugar, ";
        }
        public override double getCost()
        {
            return tempCoffee.getCost() + .20;
        }
    }
}
