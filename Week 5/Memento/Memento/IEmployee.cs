using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Genre { get; set; }
        int Age { get; set; }
    }
}
