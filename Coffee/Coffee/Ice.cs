using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Ice:Decorator
    {
        //public Ice(ICoffee newCoffee)
        //{

        //}

        public string getDescription()
        {
            return tempCoffee.getDescription() + ", Ice, Cream";
        }
        public double getCost()
        {
            return tempCoffee.getCost() + .90;
        }
    }
}
