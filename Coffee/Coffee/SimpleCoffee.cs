using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class SimpleCoffee:ICoffee
    {
        public string getDescription()
        {
            return "Water, Coffee";
        }

        public double getCost()
        {
            return 1.00;
        }
    }
}
