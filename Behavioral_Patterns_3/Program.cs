using static Behavioral_Patterns_3.FinancialElements;

namespace Behavioral_Patterns_3
{
    internal class Program
    {
        static void Main()
        {
            var incomeStatement = new IncomeStatement { Revenue = 100000, Expenses = 60000 };
            var balanceSheet = new BalanceSheet { Assets = 500000, Liabilities = 300000 };
            var cashFlowStatement = new CashFlowStatement { CashInflows = 150000, CashOutflows = 120000 };

            var financialReportVisitor = new FinancialReportVisitor();

            incomeStatement.Accept(financialReportVisitor);
            balanceSheet.Accept(financialReportVisitor);
            cashFlowStatement.Accept(financialReportVisitor);
        }
    }
}
