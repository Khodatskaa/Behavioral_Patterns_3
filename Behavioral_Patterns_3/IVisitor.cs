using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public interface IVisitor
    {
        void Visit(Coffee coffee);
        void Visit(Tea tea);
    }
}
