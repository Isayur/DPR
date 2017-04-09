using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Dog:Animal
    {
        public string returnType()
        {
            return "Half dog, half wolf.";
        }

        public string speak()
        {
            return "Bark, Bark";
        }
    }
}
