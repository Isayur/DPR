using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Cat:Animal
    {
        public string returnType()
        {
            return "It's a cat!";
        }

        public string speak()
        {
            return "Meow, meow";
        }
    }
}
