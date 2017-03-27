using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TurnTVDown : Command
    {
        ElectronicDevice theDevice;

        public TurnTVDown(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public string execute()
        {
            return theDevice.volumeDown();
        }
    }
}
