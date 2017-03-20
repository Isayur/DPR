using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Employee
    {
        public Employee() { }
        
        public Employee(string fName, string lName, string add, string pos, int mori)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.address = add;
            this.job = pos;
            this.age = mori;
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        
        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        
        private string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        private string job;
        public string Job
        {
            get
            {
                return Job;
            }
            set
            {
                Job = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
