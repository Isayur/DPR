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
        public Form1()
        {
            InitializeComponent();
            ElectronicDevice newDevice = TVRemote.getDevice();
            TurnTVOn onCommand = new TurnTVOn(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.press();

            TurnTVOff offCommand = new TurnTVOff(newDevice);
            onPressed = new DeviceButton(offCommand);
            onPressed.press();

            TurnTVUp volUpCommand = new TurnTVUp(newDevice);
            onPressed = new DeviceButton(volUpCommand);
            onPressed.press();

            Television theTV = new Television();
            Radio theRadio = new Radio();
            List<ElectronicDevice> allDevices = new List<ElectronicDevice>();
            allDevices.Add(theTV);
            allDevices.Add(theRadio);

            TurnAllOff turnOffDevices = new TurnAllOff(allDevices);
            DeviceButton turnThemOff = new DeviceButton(turnOffDevices);
            turnThemOff.press();
        }
    }
}
