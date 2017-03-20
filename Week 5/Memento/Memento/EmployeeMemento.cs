using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EmployeeMemento
    {
        public EmployeeMemento(Employee main)
        {
            firstName = main.FirstName;
            lastName = main.LastName;
            address = main.Address;
            job = main.Job;
            age = main.Age;
            created = DateTime.Now.ToString("h:mm:ss tt");
        }

        private string created;
        public string Created { get { return created; } }
        
        private string firstName;
        
        private string lastName;

        private string address;

        private string job;
       
        private int age;

        public Employee getMemento()
        {
            Employee temp = new Memento.Employee(firstName, lastName, address, job, age);
            return temp;
        }

    }
}
