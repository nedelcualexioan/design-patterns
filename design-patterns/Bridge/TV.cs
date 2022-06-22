using System;

namespace design_patterns.Bridge
{
    public class TV : Device
    {

        public TV(int deviceState, int maxSetting)
        {
            base.deviceState = deviceState;
            base.maxSetting = maxSetting;
        }
        public override void buttonFivePressed()
        {
            deviceState--;

            Console.WriteLine("Channel down");
        }

        public override void buttonSixPressed()
        {
            deviceState++;

            Console.WriteLine("Channel up");
        }
    }
}