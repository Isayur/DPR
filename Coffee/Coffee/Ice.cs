using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Ice : Decorator
    {
        public Ice(ICoffee newCoffee)
        {
            ICoffee tempCoffee = newCoffee;
        }

        public override string getDescription()
        {
            return tempCoffee.getDescription() + ", Ice";
        }
        public override double getCost()
        {
            return tempCoffee.getCost() + 0.10;
        }
    }
}
