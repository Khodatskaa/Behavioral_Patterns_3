using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class RobotArm : IRobot
    {
        public void Accept(IRobotVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Operate()
        {
            Console.WriteLine("Robot arm is operating.");
        }
    }

    public class RobotLeg : IRobot
    {
        public void Accept(IRobotVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Move()
        {
            Console.WriteLine("Robot leg is moving.");
        }
    }

    public class RobotHead : IRobot
    {
        public void Accept(IRobotVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Scan()
        {
            Console.WriteLine("Robot head is scanning.");
        }
    }
}
