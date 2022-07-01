namespace design_patterns.Adapter
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        private EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot robot)
        {
            theRobot = robot;
        }

        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }

        public void driveForward()
        {
            theRobot.walkForward();
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }
    }
}