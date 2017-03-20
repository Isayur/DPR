using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee currentEmployee = new Employee();
        List<EmployeeMemento> employeeMementos = new List<EmployeeMemento>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayDetails()
        {
            tbFirstName.Text = currentEmployee.FirstName;
            tbLastName.Text = currentEmployee.LastName;
            tbAddress.Text = currentEmployee.Address;
            tbGenre.Text = currentEmployee.Job;
            tbAge.Text = currentEmployee.Age.ToString();
        }

        private void btnNewMemento_Click(object sender, EventArgs e)
        {
            currentEmployee.FirstName = tbFirstName.Text;
            currentEmployee.LastName = tbLastName.Text;
            currentEmployee.Address = tbAddress.Text;
            currentEmployee.Job = tbGenre.Text;
            currentEmployee.Age = Convert.ToInt32(tbAge.Text);
            employeeMementos.Add(new EmployeeMemento(currentEmployee));
            MementoLb.Items.Add(employeeMementos[employeeMementos.Count-1].Created);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(currentEmployee.FirstName == tbFirstName.Text && currentEmployee.LastName == tbLastName.Text && currentEmployee.Address == tbAddress.Text && 
                currentEmployee.Job == tbGenre.Text && currentEmployee.Age == Convert.ToInt32(tbAge.Text))
            {
                MessageBox.Show("There is nothing to save.");
            }
            else
            {
                currentEmployee.FirstName = tbFirstName.Text;
                currentEmployee.LastName = tbLastName.Text;
                currentEmployee.Address = tbAddress.Text;
                currentEmployee.Job = tbGenre.Text;
                currentEmployee.Age = Convert.ToInt32(tbAge.Text);
                MessageBox.Show("Saved all changes to the current employee.");
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (MementoLb.SelectedIndex == -1) { MessageBox.Show("Select a memento first."); }
            else
            {
                currentEmployee = employeeMementos[MementoLb.SelectedIndex].getMemento();
                DisplayDetails();
            }
        }
    }
}
