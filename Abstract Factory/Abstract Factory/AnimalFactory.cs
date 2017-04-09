using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class AnimalFactory
    {
        public abstract Animal getAnimal(String animalType);

        public static AnimalFactory getAnimalFactory(String factoryType)
        {
            AnimalFactory animalFactory = null;
            if ("sea".Equals(factoryType))
            {
                animalFactory = new SeaAnimalFactory();
            }
            else
            {
                animalFactory = new LandAnimalFactory();
            }
            return animalFactory;
        }
    }
}
