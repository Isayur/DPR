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
        public void on()
        {
            MessageBox.Show("TV is ON");
        }

        public void off()
        {
            MessageBox.Show("TV is OFF");
        }

        public void volumeUp()
        {
            volume++;
            MessageBox.Show("TV volume is at " + volume);
        }

        public void volumeDown()
        {
            volume--;
            MessageBox.Show("TV volume is at " + volume);
        }
    }
}
