using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Behavioral_Patterns_3.FinancialElements;

namespace Behavioral_Patterns_3
{
    public class FinancialReportVisitor : IFinancialVisitor
    {
        public void Visit(IncomeStatement incomeStatement)
        {
            double netIncome = incomeStatement.Revenue - incomeStatement.Expenses;
            Console.WriteLine("Net Income: $" + netIncome);
        }

        public void Visit(BalanceSheet balanceSheet)
        {
            double equity = balanceSheet.Assets - balanceSheet.Liabilities;
            Console.WriteLine("Equity: $" + equity);
        }

        public void Visit(CashFlowStatement cashFlowStatement)
        {
            double netCashFlow = cashFlowStatement.CashInflows - cashFlowStatement.CashOutflows;
            Console.WriteLine("Net Cash Flow: $" + netCashFlow);
        }
    }
}
