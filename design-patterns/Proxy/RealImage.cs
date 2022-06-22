using System;
using System.Runtime.CompilerServices;

namespace design_patterns.Proxy
{
    public class RealImage : IImage
    {
        private String fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;

            this.loadFrom(fileName);
        }

        public void display()
        {
            Console.WriteLine(fileName);
        }

        private void loadFrom(String file)
        {

            Console.WriteLine("Loading "+file);
        }


    }
}