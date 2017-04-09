using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Animal animal = null;
            AnimalFactory animalFactory = null;
            //String speak = null;

            //Get Factory object by passing the factory type

            animalFactory = AnimalFactory.getAnimalFactory("sea");

            //MessageBox.Show("Animal Factory type: " + animalFactory
        }
    }
}
