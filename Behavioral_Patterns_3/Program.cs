namespace Behavioral_Patterns_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRobot> robots = new List<IRobot>
            {
                new RobotArm(),
                new RobotLeg(),
                new RobotHead()
            };

            IRobotVisitor visitor = new RobotControlVisitor();

            foreach (var robot in robots)
            {
                robot.Accept(visitor);
            }
        }
    }
}
