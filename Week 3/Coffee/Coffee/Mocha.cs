using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Mocha : ICoffee
    {
        public string getDescription()
        {
            return "Mocha with ";
        }

        public double getCost()
        {
            return 2.00;
        }
    }
}
