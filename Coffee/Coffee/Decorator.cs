using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public abstract class Decorator : ICoffee
    {
        protected ICoffee tempCoffee;
        
        public abstract string getDescription();

        public abstract double getCost();
    }
}
