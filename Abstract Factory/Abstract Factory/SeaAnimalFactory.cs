using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class SeaAnimalFactory:AnimalFactory
    {
        public Animal getAnimal(String animalType)
        {
            Animal animal  = null;
            if ("shark".Equals(animalType))
            {
                animal = new Shark();
            }
            return animal;
        }
    }
}
