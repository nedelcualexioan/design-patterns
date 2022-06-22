using System;
using design_patterns.Decorator;
using design_patterns.Proxy;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage x = new ProxyImage("asdasdas");

            
            x.display();
        }
    }
}
