using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class Espresso : ICoffee
    {
        public string getDescription()
        {
            return "Espresso with ";
        }

        public double getCost()
        {
            return 3.22;
        }
    }
}
