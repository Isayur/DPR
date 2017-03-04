using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Espresso: Decorator
    {
        //public Espresso(ICoffee newCoffee)
        //{
            
        //}

        public string getDescription()
        {
            return tempCoffee.getDescription() + ", Water, Grind, Dose";
        }
        public double getCost()
        {
            return tempCoffee.getCost() + .50;
        }
    }
}
