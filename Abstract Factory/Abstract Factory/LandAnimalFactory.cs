using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class LandAnimalFactory:AnimalFactory
    {
        public override Animal getDocileAnimal()
        {
            return new Dog();
        }
        public override Animal getFerociousAnimal()
        {
            return new Cat();
        }
    }
}
