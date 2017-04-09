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
        Animal animal;
        AnimalFactory animalFactoryMain;
        public Form1()
        {
            InitializeComponent();
            animalFactoryMain = new AnimalFactory();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                animalFactoryMain.setAnimalFactory("land");
                animal = null;
                listBox1.Items.Add("Factory type changed to land animal factory");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                animalFactoryMain.setAnimalFactory("sea");
                animal = null;
                listBox1.Items.Add("Factory type changed to sea animal factory");
            }
        }

        private void getDocile_Click(object sender, EventArgs e)
        {
            if (animalFactoryMain.CurrentFactory != null)
            {
                animal = animalFactoryMain.getDocileAnimal();
                listBox1.Items.Add("New docile animal fetched");
            }
            else { MessageBox.Show("Select an animal factory first"); }
        }

        private void getFerocious_Click(object sender, EventArgs e)
        {
            if (animalFactoryMain.CurrentFactory != null)
            {
                animal = animalFactoryMain.getFerociousAnimal();
                listBox1.Items.Add("New ferocious animal fetched");
            }
            else { MessageBox.Show("Select an animal factory first"); }
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            if(animal != null)
            {
                listBox1.Items.Add(animal.returnType());
            }
            else if (animalFactoryMain.CurrentFactory == null) { MessageBox.Show("Select an animal factory and fetch an animal first"); }
            else { MessageBox.Show("Fetch an animal first"); }
        }

        private void btnMakeSounds_Click(object sender, EventArgs e)
        {
            if (animal != null)
            {
                listBox1.Items.Add(animal.speak());
            }
            else if (animalFactoryMain.CurrentFactory == null) { MessageBox.Show("Select an animal factory and fetch an animal first"); }
            else { MessageBox.Show("Fetch an animal first"); }
        }
    }
}
