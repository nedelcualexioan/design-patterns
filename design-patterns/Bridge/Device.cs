using System;

namespace design_patterns.Bridge
{
    public abstract class Device // TV or DVD
    {
        public int deviceState;
        // channel or chapter (TV vs DVD)

        public int maxSetting;
        // max channel / chapter (TV/DVD)

        public int volumeLevel = 0;

        public abstract void buttonFivePressed();
        public abstract void buttonSixPressed();

        public void feedback()
        {
            if (deviceState > maxSetting || deviceState < 0)
            {
                deviceState = 0;

                Console.WriteLine("On " + deviceState);
            }
        }

        public void buttonSevenPressed()
        {
            volumeLevel++;

            Console.WriteLine("Volume level: " + volumeLevel);
        }

        public void buttonEightPressed()
        {
            volumeLevel--;

            Console.WriteLine("Volume level: " + volumeLevel);
        }



    }
}