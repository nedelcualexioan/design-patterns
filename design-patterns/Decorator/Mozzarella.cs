using System;

namespace design_patterns.Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding mozzarella");
        }

        public override String getDescription()
        {
            return pizza.getDescription() + ", Mozarella";
        }

        public override float getCost()
        {
            return pizza.getCost() + 0.5f;
        }
    }
}