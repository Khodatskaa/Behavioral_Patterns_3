using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class FinancialElements
    {
        public class IncomeStatement : IFinancialElement
        {
            public double Revenue { get; set; }
            public double Expenses { get; set; }

            public void Accept(IFinancialVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class BalanceSheet : IFinancialElement
        {
            public double Assets { get; set; }
            public double Liabilities { get; set; }

            public void Accept(IFinancialVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class CashFlowStatement : IFinancialElement
        {
            public double CashInflows { get; set; }
            public double CashOutflows { get; set; }

            public void Accept(IFinancialVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
    }
}
