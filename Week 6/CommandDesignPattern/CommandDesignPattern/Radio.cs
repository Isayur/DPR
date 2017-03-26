using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandDesignPattern
{
    public class Radio:ElectronicDevice
    {
        private int volume = 0;
        public void on()
        {
            MessageBox.Show("Radio is ON");
        }

        public void off()
        {
            MessageBox.Show("Radio is OFF");
        }

        public void volumeUp()
        {
            volume++;
            MessageBox.Show("Radio volume is at " + volume);
        }

        public void volumeDown()
        {
            volume--;
            MessageBox.Show("Radio volume is at " + volume);
        }
    }
}
