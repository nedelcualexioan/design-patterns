using System;

namespace design_patterns.Bridge
{
    public abstract class RemoteControl
    {
        private Device device;
        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void buttonFivePressed()
        {
            device.buttonFivePressed();
        }

        public void buttonSixPressed()
        {
            device.buttonSixPressed();
        }

        public void deviceFeedback()
        {
            device.feedback();
        }

        public abstract void buttonNinePressed();
    }
}