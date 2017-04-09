using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Shark:Animal
    {
        public string returnType()
        {
            return "Something famous for eating pirates' limbs.";
        }

        public string speak()
        {
            return "A talking ghost shark? Are you crazy?";
        }
    }
}
