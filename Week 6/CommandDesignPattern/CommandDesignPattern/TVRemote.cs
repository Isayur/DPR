using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TVRemote
    {
        public static ElectronicDevice getDevice()
        {
            return new Television();
        }
    }
}
