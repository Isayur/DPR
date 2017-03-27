using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnTVOff:Command
    {
         ElectronicDevice theDevice;

        public TurnTVOff(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public string execute()
        {
            return theDevice.off();
        }
    }
}
