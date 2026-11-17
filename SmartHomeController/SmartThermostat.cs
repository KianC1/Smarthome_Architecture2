using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        private double currentTemperature;
        private double targetTemperature;

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        public SmartThermostat(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, double CurrentTemperature, double TargetTemperature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            this.CurrentTemperature = CurrentTemperature;
            this.TargetTemperature = TargetTemperature;
        }

        public void SetTemperature()
        {
        }

        public void SetCurrentTemperature()
        {
        }

        public override void GetStatus()
        {
        }

    }
}
