using System;

namespace design_patterns.Bridge
{
    public class DVDRemote : RemoteControl
    {

        public DVDRemote(Device device) : base(device)
        {
        }

        public override void buttonNinePressed()
        {
            Console.WriteLine("DVD was paused");
        }
    }
}