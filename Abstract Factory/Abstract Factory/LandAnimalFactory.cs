using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class LandAnimalFactory:AnimalFactory
    {
        public Animal getAnimal(string animalType)
        {
            Animal animal = null;
            if ("dog".Equals(animalType))
            {
                animal = new Dog();
            }
            else if ("cat".Equals(animalType))
            {
                animal = new Cat();
            }
            return animal;
        }
    }
}
