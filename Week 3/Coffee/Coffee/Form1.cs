using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ICoffee currentCoffee = null;

        private void selectSimple_Click(object sender, EventArgs e)
        {
            currentCoffee = new SimpleCoffee();
            UpdateSelection();
        }

        private void selectEspresso_Click(object sender, EventArgs e)
        {
            currentCoffee = new Espresso();
            UpdateSelection();
        }

        private void selectMocha_Click(object sender, EventArgs e)
        {
            currentCoffee = new Mocha();
            UpdateSelection();
        }

        private void addSugar_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Sugar(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void addWhip_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Whip(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void addChocolate_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Chocolate(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void addIce_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Ice(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void addSoy_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Soy(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void addMilk_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                currentCoffee = new Milk(currentCoffee);
                UpdateSelection();
            }
            else { MessageBox.Show("Please select a coffee type first"); }
        }

        private void finishCreation_Click(object sender, EventArgs e)
        {
            if (currentCoffee != null)
            {
                string desc = currentCoffee.getDescription();
                if (desc.Substring(desc.Length - 5, 5) == "with ")
                {
                    beveragesSoldLb.Items.Add("Sold plain " + desc.Substring(0,desc.Length-6) + " for " + currentCoffee.getCost());
                }
                else
                {
                    beveragesSoldLb.Items.Add("Sold " + desc.Substring(0, currentCoffee.getDescription().Length - 2) + " for " + currentCoffee.getCost());
                }
                currentCoffee = null;
            }
            else { MessageBox.Show("There is no coffee selected."); }
        }

        private void UpdateSelection()
        {
            if (currentCoffee != null)
            {
                string desc = currentCoffee.getDescription();
                if (desc.Substring(desc.Length - 5, 5) == "with ")
                {
                    currentCoffeeTb.Text = "Plain " + desc.Substring(0, desc.Length-6) + " Cost: " + currentCoffee.getCost();
                }
                else
                {
                    currentCoffeeTb.Text = desc.Substring(0, currentCoffee.getDescription().Length - 2) + " Cost: " + currentCoffee.getCost();
                }
            }
            else { currentCoffeeTb.Text = ""; }
        }
    }
}