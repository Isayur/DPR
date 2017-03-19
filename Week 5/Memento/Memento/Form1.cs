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
        Employee employee = new Employee
        {
            FirstName = "Jason",
            LastName = "Statham",
            Address = "1600 Shirebrook, The Great Britain",
            Genre = "Male",
            Age = 30,
            Original = new EmployeeClone
            {
                FirstName = "Jason",
                LastName = "Statham",
                Address = "1600 Shirebrook, The Great Britain",
                Genre = "Male",
                Age = 30,
            }
        };

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            tbAddress.Text = employee.Address;
            tbGenre.Text = employee.Genre;
            tbAge.Text = employee.Age.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.Address = tbAddress.Text;
            employee.Genre = tbGenre.Text;
            employee.Age = Convert.ToInt32(tbAge.Text);
            if (employee.IsModified())
            {
                employee.Original.FirstName = employee.FirstName;
                employee.Original.LastName = employee.LastName;
                employee.Original.Address = employee.Address;
                employee.Original.Genre = employee.Genre;
                employee.Original.Age = employee.Age;   
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.Address = tbAddress.Text;
            employee.Genre = tbGenre.Text;
            employee.Age = Convert.ToInt32(tbAge.Text);
            if (employee.IsModified())
            {
                MessageBox.Show("Data is changed");
            }
            else
            {
                MessageBox.Show("Data is not changed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employee.Revert();
            DisplayDetails();
        }
    }
}
