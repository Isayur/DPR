using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Soy: Decorator
    {
        //public Soy(ICoffee newCoffee)
        //{

        //}

        public string getDescription()
        {
            return tempCoffee.getDescription() + ", Milk, Soy, Vanilia";
        }
        public double getCost()
        {
            return tempCoffee.getCost() + .70;
        }
    }
}
