using System;

namespace design_patterns.Adapter
{
    public interface IEnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(String driverName);

    }
}