using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandDesignPattern
{
    public partial class Form1 : Form
    {
        List<ElectronicDevice> currentDevices;
        public Form1()
        {
            InitializeComponent();
            currentDevices = new List<ElectronicDevice>();
        }

        private void addTVBtn_Click(object sender, EventArgs e)
        {
            ElectronicDevice temp = new Television();
            currentDevices.Add(temp);
            listBox1.Items.Add("Television; Off");

        }

        private void addRadioBtn_Click(object sender, EventArgs e)
        {
            ElectronicDevice temp = new Radio();
            currentDevices.Add(temp);
            listBox1.Items.Add("Radio; Off");
        }

        private void TurnOnBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { MessageBox.Show("Select a device first"); }
            else
            {
                ElectronicDevice temp = currentDevices[listBox1.SelectedIndex];
                if (temp.getStatus()) { MessageBox.Show("Device is already on"); }
                else
                {
                    TurnTVOn onCommand = new TurnTVOn(temp);
                    DeviceButton onPress = new DeviceButton(onCommand);
                    listBox1.Items[listBox1.SelectedIndex] = onPress.press();
                }
            }
        }

        private void TurnOffBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { MessageBox.Show("Select a device first"); }
            else
            {
                ElectronicDevice temp = currentDevices[listBox1.SelectedIndex];
                if (!temp.getStatus()) { MessageBox.Show("Device is already off"); }
                else
                {
                    TurnTVOff onCommand = new TurnTVOff(temp);
                    DeviceButton onPress = new DeviceButton(onCommand);
                    listBox1.Items[listBox1.SelectedIndex] = onPress.press();
                }
            }
        }

        private void VolumeUpBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { MessageBox.Show("Select a device first"); }
            else
            {
                ElectronicDevice temp = currentDevices[listBox1.SelectedIndex];
                if (!temp.getStatus()) { MessageBox.Show("Turn on the device first"); }
                else
                {
                    TurnTVUp onCommand = new TurnTVUp(temp);
                    DeviceButton onPress = new DeviceButton(onCommand);
                    listBox1.Items[listBox1.SelectedIndex] = onPress.press();
                }
            }
        }

        private void VolumeDownBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { MessageBox.Show("Select a device first"); }
            else
            {
                ElectronicDevice temp = currentDevices[listBox1.SelectedIndex];
                if (!temp.getStatus()) { MessageBox.Show("Turn on the device first"); }
                else
                {
                    TurnTVDown onCommand = new TurnTVDown(temp);
                    DeviceButton onPress = new DeviceButton(onCommand);
                    listBox1.Items[listBox1.SelectedIndex] = onPress.press();
                }
            }
        }

        private void TurnAllOffBtn_Click(object sender, EventArgs e)
        {
            TurnAllOff onCommand = new CommandDesignPattern.TurnAllOff(currentDevices);
            DeviceButton onPress = new CommandDesignPattern.DeviceButton(onCommand);
            onPress.press();
            listBox1.Items.Clear();
            foreach(ElectronicDevice device in currentDevices)
            {
                listBox1.Items.Add(device.getStatusString());
            }
        }
    }
}
