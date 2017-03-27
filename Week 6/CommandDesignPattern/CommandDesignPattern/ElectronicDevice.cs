using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public interface ElectronicDevice
    {
        string on();

        string off();

        string volumeUp();

        string volumeDown();
        bool getStatus();

        string getStatusString();
    }
}
