using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Employee:IEmployee
    {
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

        private string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
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
        private EmployeeClone original = new EmployeeClone();
        public EmployeeClone Original
        {
            get
            {
                return original;
            }
            set
            {
                original = value;
            }
        }
        public void Revert()
        {
            this.FirstName = Original.FirstName;
            this.LastName = Original.LastName;
            this.Address = Original.Address;
            this.Genre = Original.Genre;
            this.Age = Original.Age;
        }
        public Boolean IsModified()
        {
            return !(this.FirstName.Equals(Original.FirstName) && this.LastName.Equals(Original.LastName) && 
                this.Address.Equals(Original.Address) && this.Genre.Equals(Original.Genre) && this.Age.Equals(Original.Age));
        }
    }
}
