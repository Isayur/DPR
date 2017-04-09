using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Starfish : Animal
    {
        public string returnType()
        {
            return "Starfish. Like Patrick.";
        }

        public string speak()
        {
            return "No, this is Patrick!";
        }
    }
}
