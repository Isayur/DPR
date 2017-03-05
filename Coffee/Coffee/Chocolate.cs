using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Chocolate : Decorator
    {
        public Chocolate(ICoffee newCoffee)
        {
            tempCoffee = newCoffee;
        }

        public override string getDescription()
        {
            return tempCoffee.getDescription() + ", Soy";
        }
        public override double getCost()
        {
            return tempCoffee.getCost() + .80;
        }
    }
}
