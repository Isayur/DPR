using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnAllOff:Command
    {
        List<ElectronicDevice> theDevices;
        public TurnAllOff(List<ElectronicDevice> newDevices)
        {
            theDevices = newDevices;
        }

        public void execute()
        {
            //прост for loop, който ще shut down всяко едно устройство
        }
    }
}
