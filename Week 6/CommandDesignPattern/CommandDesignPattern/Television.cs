using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandDesignPattern
{
    public class Television:ElectronicDevice
    {
        private int volume = 0;
        private bool status = false;
        private string statusString;
        public string on()
        {
            status = true;
            statusString = "Television; Volume: " + volume;
            return statusString;
        }

        public string off()
        {
            status = false;
            statusString = "Television; Off";
            return statusString;
        }

        public string volumeUp()
        {
            if (volume < 100) { volume++; }
            else { MessageBox.Show("Volume cannot be above 1000"); }
            statusString = "Television; Volume: " + volume;
            return statusString;
        }

        public string volumeDown()
        {
            if (volume > 0) { volume--; }
            else { MessageBox.Show("Volume cannot be below 0"); }
            statusString = "Television; Volume: " + volume;
            return statusString;
        }
        public bool getStatus()
        {
            return status;
        }
        public string getStatusString()
        {
            return statusString;
        }
    }
}
