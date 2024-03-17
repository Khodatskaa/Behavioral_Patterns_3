using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class Coffee : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee...");
        }

        public void AddSugar()
        {
            Console.WriteLine("Adding sugar to coffee...");
        }
    }

    public class Tea : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void BrewTea()
        {
            Console.WriteLine("Brewing tea...");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding lemon to tea...");
        }
    }
}
