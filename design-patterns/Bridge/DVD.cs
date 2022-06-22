using System;
using System.Threading;

namespace design_patterns.Bridge
{
    public class DVD : Device
    {

        public DVD(int deviceState, int maxSetting)
        {
            base.deviceState = deviceState;
            base.maxSetting = maxSetting;
        }
        public override void buttonFivePressed()
        {
            deviceState--;

            Console.WriteLine("Previous chapter");
        }

        public override void buttonSixPressed()
        {
            deviceState++;

            Console.WriteLine("Next chapter");
        }
    }
}