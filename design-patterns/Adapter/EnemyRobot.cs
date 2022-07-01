using System;

namespace design_patterns.Adapter
{
    public class EnemyRobot
    {
        public void smashWithHands()
        {
            Console.WriteLine("Enemy robot causes 20 damage with its hands");
        }

        public void walkForward()
        {
            Console.WriteLine("Enemy robot walks forward 3 spaces");
        }

        public void reactToHuman(String driverName)
        {
            Console.WriteLine("Enemy robot tramps on " + driverName);
        }
    }
}