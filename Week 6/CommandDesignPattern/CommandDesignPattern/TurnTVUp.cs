using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnTVUp:Command
    {
        ElectronicDevice theDevice;

        public TurnTVUp(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.volumeUp();
        }
    }
}
