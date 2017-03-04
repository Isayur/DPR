using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    abstract class Decorator: ICoffee
    {
        protected ICoffee tempCoffee;

        public Decorator(ICoffee newCoffee)
        {
            tempCoffee = newCoffee;
        }
        public string getDescription()
        {
            return tempCoffee.getDescription();
        }

        public double getCost()
        {
            return tempCoffee.getCost();
        }
    }
}
