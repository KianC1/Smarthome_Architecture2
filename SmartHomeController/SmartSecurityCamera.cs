using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera
    {
        private string resolution;
        private bool recordingStatus;

        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }

        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set { recordingStatus = value; }
        }

    }
}
