﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnTVOn:Command
    {
        ElectronicDevice theDevice;

        public TurnTVOn(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public string execute()
        {
            return theDevice.on();
        }
    }
}
