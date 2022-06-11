using System;

namespace design_patterns.Decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza pizza;

        public ToppingDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual String getDescription()
        {
            return pizza.getDescription();
        }

        public virtual float getCost()
        {
            return pizza.getCost();
        }
    }
}