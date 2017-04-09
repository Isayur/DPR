using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory
{
    public class AnimalFactory
    {
        static AnimalFactory currentFactory;
        public AnimalFactory CurrentFactory { get { return currentFactory; } }
        public virtual Animal getDocileAnimal()
        {
            return currentFactory.getDocileAnimal();
        }
        public virtual Animal getFerociousAnimal()
        {
            return currentFactory.getFerociousAnimal();
        }
        

        public void setAnimalFactory(String factoryType)
        {
            if ("sea".Equals(factoryType))
            {
                currentFactory = new SeaAnimalFactory();
            }
            else if ("land".Equals(factoryType))
            {
                currentFactory = new LandAnimalFactory();
            }
            else
            {
                MessageBox.Show("Invalid factory type");
            }
        }
    }
}
