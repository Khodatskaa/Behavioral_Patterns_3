using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class BeveragePreparationVisitor : IVisitor
    {
        public void Visit(Coffee coffee)
        {
            coffee.BrewCoffee();
            coffee.AddSugar();
        }

        public void Visit(Tea tea)
        {
            tea.BrewTea();
            tea.AddLemon();
        }
    }
}
