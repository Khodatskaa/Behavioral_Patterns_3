using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public interface IRobot
    {
        void Accept(IRobotVisitor visitor);
    }
}
