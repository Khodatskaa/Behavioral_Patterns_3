using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Behavioral_Patterns_3.FinancialElements;

namespace Behavioral_Patterns_3
{
    public interface IFinancialVisitor
    {
            void Visit(IncomeStatement incomeStatement);
            void Visit(BalanceSheet balanceSheet);
            void Visit(CashFlowStatement cashFlowStatement);
    }
}
