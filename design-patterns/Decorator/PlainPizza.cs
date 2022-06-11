namespace design_patterns.Decorator
{
    public class PlainPizza : IPizza
    {
        public float getCost()
        {
            return 10;
        }

        public string getDescription()
        {
            return "Plain pizza";
        }
    }
}