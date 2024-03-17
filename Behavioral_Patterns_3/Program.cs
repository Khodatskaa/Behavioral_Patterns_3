namespace Behavioral_Patterns_3
{
    internal class Program
    {
        static void Main()
        {
            var beveragePreparationVisitor = new BeveragePreparationVisitor();

            var coffee = new Coffee();
            coffee.Accept(beveragePreparationVisitor);

            var tea = new Tea();
            tea.Accept(beveragePreparationVisitor);

            Console.ReadLine();
        }
    }
}
