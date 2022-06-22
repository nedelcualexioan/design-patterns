using System;

namespace design_patterns.Bridge
{
    public class TVRemote : RemoteControl
    {
        public TVRemote(Device device) : base(device) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("TV was muted");
        }
    }
}