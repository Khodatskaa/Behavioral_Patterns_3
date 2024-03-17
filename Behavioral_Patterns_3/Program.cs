namespace Behavioral_Patterns_3
{
    internal class Program
    {
        static void Main()
        {
            Document document = new Document();
            document.Attach(new TextElement("Hello, world!"));
            document.Attach(new ImageElement("path/to/image.jpg"));
            document.Attach(new TableElement(new List<List<string>> { new List<string> { "Cell1", "Cell2" }, new List<string> { "Cell3", "Cell4" } }));

            IVisitor processor = new DocumentProcessor();
            document.Accept(processor);

            Console.ReadLine();
        }
    }
}
