using System;

namespace design_patterns.Decorator
{
    public class Example
    {
        public void run()
        {
            IPizza pizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + pizza.getDescription()); 
        }
    }
}