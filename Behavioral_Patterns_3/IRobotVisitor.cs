using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public interface IRobotVisitor
    {
        void Visit(RobotArm robotArm);
        void Visit(RobotLeg robotLeg);
        void Visit(RobotHead robotHead);
    }

    public class RobotControlVisitor : IRobotVisitor
    {
        public void Visit(RobotArm robotArm)
        {
            robotArm.Operate();
        }

        public void Visit(RobotLeg robotLeg)
        {
            robotLeg.Move();
        }

        public void Visit(RobotHead robotHead)
        {
            robotHead.Scan();
        }
    }
}
