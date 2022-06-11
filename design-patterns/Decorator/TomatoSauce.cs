using System;

namespace design_patterns.Decorator
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding sauce");
        }

        public override String getDescription()
        {
            return pizza.getDescription() + ", Tomato sauce";
        }

        public override float getCost()
        {
            return pizza.getCost() + 0.35f;
        }
    }
}