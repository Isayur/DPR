using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class DeviceButton
    {
        Command theCommand;
        public DeviceButton(Command newCommand)
        {
            theCommand = newCommand;
        }
        public string press()
        {
            return theCommand.execute();
        }
    }
}
