using System;

namespace design_patterns.Adapter
{
    public class EnemyTank : IEnemyAttacker
    {
        public void assignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }

        public void driveForward()
        {
            Console.WriteLine("Enemy tank moves 10 spaces");
        }

        public void fireWeapon()
        {
            Console.WriteLine("Enemy Tank Does: 50 Damage");
        }
    }
}